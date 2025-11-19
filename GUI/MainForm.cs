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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            pb_wallpaper.BringToFront();
            lbl_ChhipaMotors_Text.BringToFront();
            lbl_ChhipaMotors_Text.Parent = pb_wallpaper;
            lbl_ChhipaMotors_Text.BackColor = Color.Transparent;
            pb_Acc.Parent = pb_wallpaper;
        }
    }
}
