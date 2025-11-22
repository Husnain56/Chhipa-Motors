using SiticoneNetCoreUI;
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

namespace Chhipa_Motors.GUI.Car_Cards
{
    public partial class TestForm : Form
    {
        private SiticoneButton btnBack;

        public TestForm(string manufacturer)
        {
            InitializeComponent();
            this.ControlBox = false;
            LoadManufacturerControl(manufacturer);
        }

        public void SetupBackButton()
        {
            btnBack = new SiticoneButton
            {
                Text = "← Back",
                Size = new Size(120, 45),
                Location = new Point(20, 15)
            };
            btnBack.Click += (s, e) => this.Close();
            this.Controls.Add(btnBack);
            btnBack.BringToFront();
        }

        public void LoadPage(UserControl page)
        {
            Controls.Clear();
            Controls.Add(page);
            page.Dock = DockStyle.Fill;
            SetupBackButton();
            
        }
        void LoadManufacturerControl(string manufacturer)
        {
            if (manufacturer == "Porsche")
            {
                LoadPage(new UserControl_Porsche());
            }
            else if(manufacturer=="Nissan")
            {
                LoadPage(new UserControl_Nissan());
            }
            else if (manufacturer == "Lamborghini")
            {
                LoadPage(new UserControl_Lamborghini());
            }
            else if (manufacturer == "McLaren")
            {
                LoadPage(new UserControl_McLaren());
            }
        }
    }
}
