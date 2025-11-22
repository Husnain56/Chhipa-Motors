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

namespace Chhipa_Motors.GUI.Car_Cards
{
    public partial class UserControl_Nissan : UserControl
    {
        public UserControl_Nissan()
        {
            InitializeComponent();
        }
        private void HoverEnter(object sender, EventArgs e)
        {
            SiticoneContainer container = null;

            if (sender is SiticoneContainer c)
                container = c;
            else if (sender is Control child && child.Parent is SiticoneContainer parent)
                container = parent;

            if (container != null)
            {
                container.BorderColor1 = Color.White;
                container.BorderColor2 = Color.White;
                container.BorderWidth = 2;
            }
        }

        private void HoverLeave(object sender, EventArgs e)
        {
            SiticoneContainer container = null;

            if (sender is SiticoneContainer c)
                container = c;
            else if (sender is Control child && child.Parent is SiticoneContainer parent)
                container = parent;

            if (container != null)
            {
                container.BorderColor1 = Color.Black;
                container.BorderColor2 = Color.Black;
                container.BorderWidth = 0;
            }
        }

        private void UserControl_Nissan_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is SiticoneContainer container)
                {
                    // Add events to the container itself
                    container.MouseEnter += HoverEnter;
                    container.MouseLeave += HoverLeave;

                    // Add events to all children inside container
                    foreach (Control child in container.Controls)
                    {
                        child.MouseEnter += HoverEnter;
                        child.MouseLeave += HoverLeave;
                    }
                }
            }
        }
    }
}
