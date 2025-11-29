using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chhipa_Motors.BL;
using Chhipa_Motors.DTO;

namespace Chhipa_Motors.GUI.Admin_Panel
{
    public partial class UserControl_SalesRecord : UserControl
    {
        private AdminBL _adminBL;
        public UserControl_SalesRecord()
        {
            InitializeComponent();
            _adminBL = new AdminBL();
            LoadSalesRecord(0);
        }

        public void LoadSalesRecord(int filter)
        {
            dgv_sales.DataSource = _adminBL.getSalesRecord(filter);
        }

        private void radioButton_Today_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Today.Checked)
            {
                dgv_sales.DataSource = _adminBL.getSalesRecord(1);
            }
        }

        private void radioButton_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_7.Checked)
            {
                dgv_sales.DataSource = _adminBL.getSalesRecord(7);
            }
        }

        private void radioButton_30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_30.Checked)
            {
                dgv_sales.DataSource = _adminBL.getSalesRecord(30);
            }
        }

        private void radioButton_All_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_All.Checked)
            {
                dgv_sales.DataSource = _adminBL.getSalesRecord(0);
            }
        }
    }
}
