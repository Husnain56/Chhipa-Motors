using Chhipa_Motors.BL;
using Chhipa_Motors.DTO;
using Chhipa_Motors.GUI.InputBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chhipa_Motors.GUI.Admin_Panel
{
    public partial class UserControl_BookedCars : UserControl
    {
        private AdminBL _adminBL;
        private BookingDTO _bookDTO;
        private BookingContext _bookingContext;
        public UserControl_BookedCars()
        {
            InitializeComponent();
            _adminBL = new AdminBL();
            _bookDTO = new BookingDTO();
            RefreshDataGridView();
        }

        public void RefreshDataGridView()
        {
            dgvBookings.DataSource = _adminBL.GetBookedCars();
        }

        private void dgv_booked_cars_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0) return;

            var row = dgvBookings.SelectedRows[0];
            int bookingId = Convert.ToInt32(row.Cells["BookingID"].Value);
            string currentStatus = row.Cells["Status"].Value.ToString();

            _bookingContext = new BookingContext(currentStatus)
            {
                BookingId = bookingId
            };

            UpdateUI();
        }
        private void UpdateUI()
        {
            if (_bookingContext == null) return;

            var state = _bookingContext.CurrentState;

            btn_booking_status.Text = state.ButtonText;
            btn_booking_status.Enabled = state.GetNextState() != null;

            btn_booking_cancel.Visible = state.CanCancel;
            btn_booking_cancel.Enabled = state.CanCancel;
        }

        private void btn_booking_status_Click(object sender, EventArgs e)
        {
            if (_bookingContext == null) return;

            using (var inputDialog = new InputDialog("Enter admin note:"))
            {
                if (inputDialog.ShowDialog() == DialogResult.OK)
                {
                    string adminNote = inputDialog.InputText;

                    _bookingContext.TransitionToNextState();

                    UpdateBookingInDatabase(_bookingContext.BookingId, _bookingContext.CurrentState.StateName,adminNote);

                    RefreshDataGridView();
                    UpdateUI();

                    MessageBox.Show(
                        $"Status updated to {_bookingContext.CurrentState.StateName}",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void btn_booking_cancel_Click(object sender, EventArgs e)
        {
            if (_bookingContext == null) return;

            try
            {
                var result = MessageBox.Show(
                    "Cancel this booking?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    using (var inputDialog = new InputDialog("Cancellation reason:"))
                    {
                        if (inputDialog.ShowDialog() == DialogResult.OK)
                        {
                            _bookingContext.Cancel();

                            UpdateBookingInDatabase(
                                _bookingContext.BookingId,
                                _bookingContext.CurrentState.StateName,
                                inputDialog.InputText
                            );

                            RefreshDataGridView();
                            UpdateUI();
                        }
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateBookingInDatabase(int id, string status, string note)
        {
            _bookDTO.BookingID = id;
            _bookDTO.Status = status;
            _bookDTO.AdminNote = note;

            if (_adminBL.updateBookingStatus(_bookDTO) > 0) {
                MessageBox.Show("Booking updated successfully","Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("!Booking update failed.","Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
} 
