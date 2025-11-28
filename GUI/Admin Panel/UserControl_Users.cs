using Chhipa_Motors.BL;
using Chhipa_Motors.DL;
using Chhipa_Motors.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chhipa_Motors.GUI.Admin_Panel
{
    public partial class UserControl_Users : UserControl
    {
        AdminBL _adminBL;
        UserDTO _userDTO;
        public UserControl_Users()
        {
            InitializeComponent();
            _adminBL = new AdminBL();
            _userDTO = new UserDTO();

            dgv_users.BackgroundColor = Color.FromArgb(25, 25, 40);
            dgv_users.DataSource = _adminBL.getAdmins();
            btn_deleteUser.Visible = false;
            dgv_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void radioButton_Admins_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Admins.Checked)
            {
                dgv_users.DataSource = _adminBL.getAdmins();
                btn_deleteUser.Visible = false;
            }
        }

        private void radioButton_Users_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Users.Checked)
            {
                dgv_users.DataSource = _adminBL.getUsers();
                btn_deleteUser.Visible = true;
            }
        }

        private void radioButton_Customers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Customers.Checked)
            {
                dgv_users.DataSource = _adminBL.getCustomers();
                btn_deleteUser.Visible = false;
            }
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            _userDTO.Id = dgv_users.CurrentRow.Cells["UserID"].Value.ToString();
            DialogResult result = MessageBox.Show("Do you really want to Delete the selected User?", "ConfirmStatusChange", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if(_adminBL.DeleteUser(_userDTO) > 0)
                {
                    MessageBox.Show("User Deleted Successfully");
                    if (radioButton_Users.Checked)
                    {
                        dgv_users.DataSource = _adminBL.getUsers();
                    }
                    else if (radioButton_Customers.Checked)
                    {
                        dgv_users.DataSource = _adminBL.getCustomers();
                    }
                }
                else
                {
                    MessageBox.Show("Error Deleting User");
                }
            }
            else
            {
                MessageBox.Show("Operation Cancelled");
            }
        }

        private void dgv_us_Click(object sender, EventArgs e)
        {

        }
    }
}
