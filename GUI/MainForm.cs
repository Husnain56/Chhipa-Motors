using Chhipa_Motors.GUI.Admin_Panel;
using Chhipa_Motors.GUI.Car_Cards;
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
namespace Chhipa_Motors.GUI
{
    public partial class MainForm : Form
    {
        private bool _menuPressed;
        private bool _loggedIn;
        public MainForm()
        {
            InitializeComponent();
            setStates();
            _menuPressed = false;
            _loggedIn = false;
        }
        public void setStates()
        {
            pb_wallpaper.BringToFront();
            pb_porsche_logo.BringToFront();
            pb_porsche_mf.BringToFront();
            pb_lambo_mf.BringToFront();
            pb_MacLaren_mf.BringToFront();
            pb_nissan_mf.BringToFront();
            lbl_msg.BringToFront();
            pb_menu.BringToFront();
            container_menu.BringToFront();
            pb_blur_screen.BringToFront();

            container_menu.Hide();
            pb_blur_screen.Hide();

            pb_Acc.Parent = pb_wallpaper;
            lbl_msg.Parent = pnl_main;
            pb_menu.Parent = pb_wallpaper;
            container_menu.Parent = pb_wallpaper;
            pb_blur_screen.Parent = pnl_main;

        }

        private void LoadContent(UserControl page)
        {
            page.Dock = DockStyle.Fill;
            container_menu.Panel2.Controls.Clear();
            container_menu.Panel2.Controls.Add(page);
        }

        private void pb_mf_MouseEnter(object sender, EventArgs e)
        {
            var pic = sender as SiticonePictureBox;
            pic.BorderColor = Color.Silver;
            pic.BorderWidth = 2;

        }

        private void pb_mf_MouseLeave(object sender, EventArgs e)
        {
            var pic = sender as SiticonePictureBox;
            pic.BorderWidth = 0;
        }
        private void pnl_AfterNavigate(object sender, SiticoneContentPanel.NavigationEventArgs e)
        {
            pnl_dynamic_menu.AddContentToView("Manufacturers", new Manufacturers_menu());
            pnl_dynamic_menu.AddContentToView("Purchases", new UserControl_Users());
            pnl_dynamic_menu.AddContentToView("Bookings", new UserControl_CreateAdmin());
            pnl_dynamic_menu.AddContentToView("Account Settings", new UserInfo());
        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            container_menu.Show();
            pb_blur_screen.Show();
            pb_menu.Hide();
            pnl_main.AutoScroll = false;
            pnl_dynamic_menu.AfterNavigate += pnl_AfterNavigate;
            navbar_menu.SelectedItem = navbar_menu.Items[0];
            pnl_dynamic_menu.AddContentToView("Manufacturers", new Manufacturers_menu());
        }

        private void pb_acc_Click(object sender, EventArgs e)
        {
            container_menu.Show();
            pb_blur_screen.Show();
            pb_menu.Hide();
            pnl_main.AutoScroll = false;
            pnl_dynamic_menu.AfterNavigate += pnl_AfterNavigate;
            pnl_dynamic_menu.AddContentToView("Account Settings", new UserInfo());
            navbar_menu.SelectedItem = navbar_menu.Items[3];
        }

        private void pb_blur_screen_Click(object sender, EventArgs e)
        {
            container_menu.Hide();
            pb_blur_screen.Hide();
            pb_menu.Show();
            pnl_main.AutoScroll = true;
            this.pb_wallpaper.Focus();
        }

        private void btn_close_menu_Click_1(object sender, EventArgs e)
        {
            container_menu.Hide();
            pb_blur_screen.Hide();
            pb_menu.Show();
            pnl_main.AutoScroll = true;
        }

        private void btn_menu_manufacturer_list_Click(object sender, EventArgs e)
        {
            LoadContent(new Manufacturers_menu());
        }

        private void btn_menu_acc_Click(object sender, EventArgs e)
        {
            LoadContent(new UserInfo());
        }
        private void manufacturerCard_Click(object sender, EventArgs e)
        {
            string manufacturer = ((Control)sender).Tag.ToString();
            TestForm manufacturerForm = new TestForm(manufacturer);
            manufacturerForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            manufacturerForm.ShowDialog();
        }

        //private void pb_menu_btn_MouseEnter(object sender, EventArgs e)
        //{
        //    btn_close_menu.BorderColor = Color.White;
        //    btn_close_menu.BorderWidth = 2;

        //}

        //private void pb_menu_btn_MouseLeave(object sender, EventArgs e)
        //{
        //    btn_close_menu.BorderColor = Color.Transparent; 
        //    btn_close_menu.BorderWidth = 0;
        //}
    }
}
