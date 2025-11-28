using Chhipa_Motors.BL;
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

namespace Chhipa_Motors.GUI.Admin_Panel
{
    public partial class UserControl_CreateAdmin : UserControl
    {
        UserDTO _userDTO;
        AdminBL _adminBL;
        public UserControl_CreateAdmin()
        {
            InitializeComponent();
            _userDTO = new UserDTO();
            _adminBL = new AdminBL();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_password.Clear();
            txt_username.Clear();
            txt_username.Focus();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text)){
                MessageBox.Show("All fields are required.");
                return;
            }
            
            _userDTO.Username = txt_username.Text;
            _userDTO.Password = txt_password.Text;
            _userDTO.Role = "Admin";

            if (_adminBL.CreateAdmin(_userDTO) > 0)
            {
                MessageBox.Show("Admin account created successfully!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btn_clear.PerformClick();
            }
        }
    }
}
