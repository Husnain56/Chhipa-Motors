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
            setStates();

        }
        public void setStates()
        {
            pb_wallpaper.BringToFront();
            lbl_ChhipaMotors_Text.BringToFront();
            pb_porsche_logo.BringToFront();
            pb_porsche_mf.BringToFront();
            pb_lambo_mf.BringToFront();
            pb_MacLaren_mf.BringToFront();
            pb_nissan_mf.BringToFront();
            lbl_msg.BringToFront();

            pb_Acc.Parent = pb_wallpaper;
            lbl_msg.Parent = pnl_main;

            lbl_ChhipaMotors_Text.Parent = pb_wallpaper;
            lbl_ChhipaMotors_Text.BackColor = Color.Transparent;
            lbl_msg.BackColor = Color.Transparent;
            
         
        }
    }
}
