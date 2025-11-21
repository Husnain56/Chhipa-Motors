using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chhipa_Motors.GUI
{
    public partial class UserInfo : UserControl
    {
        public UserInfo()
        {
            InitializeComponent();
            container_update_info.Hide();
        }

        private void btn_up_name_Click(object sender, EventArgs e)
        {
            container_update_info.Show();
            txt_input.PlaceholderText += "Name";
        }

        private void btn_up_email_Click(object sender, EventArgs e)
        {
            container_update_info.Show();
            txt_input.PlaceholderText += "Email";
        }

        private void btn_up_phone_Click(object sender, EventArgs e)
        {
            container_update_info.Show();
            txt_input.PlaceholderText += "Phone Number";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text!="" || txt_input.Text != "")
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
