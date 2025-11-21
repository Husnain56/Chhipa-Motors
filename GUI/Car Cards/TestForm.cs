using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chhipa_Motors.GUI.Car_Cards
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            Controls.Add(new UserControl_Porsche() { Dock = DockStyle.Fill });
        }
    }
}
