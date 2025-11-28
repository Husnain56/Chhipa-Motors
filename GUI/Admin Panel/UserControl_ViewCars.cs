using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chhipa_Motors.DTO;
using Chhipa_Motors.BL;
using Chhipa_Motors.GUI.InputBox;

namespace Chhipa_Motors.GUI.Admin_Panel
{
    public partial class UserControl_ViewCars : UserControl
    {
        private AdminBL _adminBL;
        private CarDTO _carDTO;
        public UserControl_ViewCars()
        {
            InitializeComponent();
            _adminBL = new AdminBL();
            _carDTO = new CarDTO();
            LoadCars();
        }

        public void LoadCars()
        {
            dgv_cars.DataSource = _adminBL.GetAllCars();
        }

        private void btn_update_price_Click(object sender, EventArgs e)
        {
            _carDTO.CarID = dgv_cars.CurrentRow.Cells["CarID"].Value.ToString();

            InputDialog input = new InputDialog("Enter Updated Price: ");
            string userInput = "";
            if (input.ShowDialog() == DialogResult.OK)
            {
                userInput = input.InputText;
            }
            if (userInput != "")
            {
                _carDTO.Price = userInput;
                int row_affected = _adminBL.updateCarPrice(_carDTO);
                if (row_affected > 0)
                {
                    MessageBox.Show("Price updated successfully.");
                    LoadCars();
                }
                else
                {
                    MessageBox.Show("Price update failed.");
                }
            }
            else
            {
                MessageBox.Show("Price Update Failed.");

            }
        }

        private void btn_update_stock_Click(object sender, EventArgs e)
        {
            _carDTO.CarID = dgv_cars.CurrentRow.Cells["CarID"].Value.ToString();

            InputDialog input = new InputDialog("Enter new Car Stock: ");
            string userInput = "";
            if (input.ShowDialog() == DialogResult.OK)
            {
                userInput = input.InputText;
            }
            if (userInput != "")
            {
                _carDTO.Price = userInput;
                int row_affected = _adminBL.updateCarStock(_carDTO);
                if (row_affected > 0)
                {
                    MessageBox.Show("Stock updated successfully.");
                    LoadCars();
                }
                else
                {
                    MessageBox.Show("Stock update failed.");
                }
            }
            else
            {
                MessageBox.Show("Stock Update Failed.");

            }
        }

        private void btn_change_status_Click(object sender, EventArgs e)
        {

            string currentStatus = dgv_cars.CurrentRow.Cells["Active"].Value.ToString();

            _carDTO.CarID = dgv_cars.CurrentRow.Cells["CarID"].Value.ToString();

            DialogResult result;

            if (currentStatus == "False")
            {
                result = MessageBox.Show("Do you really want to resume the car availability?", "ConfirmStatusChange", MessageBoxButtons.YesNo);
                _carDTO.Status = "True";
            }
            else
            {
                result = MessageBox.Show("Do you really want to pause the car availability?", "ConfirmStatusChange", MessageBoxButtons.YesNo);
                _carDTO.Status = "False";
            }

            if (result == DialogResult.Yes)
            {
                if (_adminBL.changeCarStatus(_carDTO) > 0)
                {
                    MessageBox.Show("Status Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Error changing status");
                }
            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }
        }

        private void dgv_cars_SelectionChanged(object sender, EventArgs e)
        {
            string currentStatus = dgv_cars.CurrentRow.Cells["Active"].Value.ToString();

            if (currentStatus == "False")
            {
                btn_change_status.Text = "Resume Availability";
            }
            else
            {
                btn_change_status.Text = "Pause Availability";
            }
        }
    }
}
