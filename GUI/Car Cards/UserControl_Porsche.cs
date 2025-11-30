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
using Chhipa_Motors.GUI.Booking_Form;
using Chhipa_Motors.DTO;
using Chhipa_Motors.BL;

namespace Chhipa_Motors.GUI.Car_Cards
{
    public partial class UserControl_Porsche : UserControl
    {
        CarBL _carBL;
        public UserControl_Porsche()
        {
            InitializeComponent();
            _carBL = new CarBL();
            LoadPorschePricesDirect();
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

        private void UserControl_Porsche_Load(object sender, EventArgs e)
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

        private void btn_book_taycanturbo_Click(object sender, EventArgs e)
        {
            BookingForm form = new BookingForm(new CarDTO(), pb_taycan.Image, "3");
            form.ShowDialog();
        }

        private void LoadPorschePricesDirect()
        {
            try
            {
                var porscheCars = _carBL.GetCarsByManufacturer("Porsche");

                // Use SiticoneLabel and SiticoneButtonAdvanced
                var carLookup = new Dictionary<string, (SiticoneLabel priceLabel, SiticoneButtonAdvanced bookButton)>
        {
            { "Taycan Turbo GT", (lbl_p_TaycanTurboGT, btn_book_TaycanTurbo) },
            { "911 Carrera 4S", (lbl_p_911Carrera4S, btn_book_carrera4S) },
            { "Panamera", (lbl_p_Panamera, btn_book_panamera) },
            { "Panamera 4S E-Hybrid", (lbl_p_Panamera4SEHybrid, btn_book_panamera4S) },
            { "Macan 4 Electric", (lbl_p_Macan4Electric, btn_book_macan4) },
            { "718 Cayman GT4 RS", (lbl_p_718CaymanGT4RS, btn_book_718Cayman) }
        };

                foreach (var car in porscheCars)
                {
                    if (carLookup.ContainsKey(car.CarName))
                    {
                        var (priceLabel, bookButton) = carLookup[car.CarName];

                        // Update price label
                        decimal price = decimal.Parse(car.Price);
                        priceLabel.Text = $"Rs. {price:N0}";
                        priceLabel.Tag = car.CarID;

                        // Update book button
                        bookButton.Tag = car.CarID;

                        // Parse stock
                        int stock = int.Parse(car.Stock);

                        // Parse active status
                        bool isActive = false;
                        if (!string.IsNullOrEmpty(car.Status))
                        {
                            string status = car.Status.Trim().ToLower();
                            isActive = status == "active" || status == "1" || status == "true";
                        }

                        // Enable button only if stock > 0 AND car is active
                        bool shouldEnable = (stock > 0 && isActive);

                        bookButton.Enabled = shouldEnable;
                        bookButton.Cursor = shouldEnable ? Cursors.Hand : Cursors.No;

                        // Change button text based on availability
                        if (shouldEnable)
                        {
                            bookButton.Text = "Book Vehicle";
                        }
                        else if (stock <= 0)
                        {
                            bookButton.Text = "Out of Stock";
                        }
                        else if (!isActive)
                        {
                            bookButton.Text = "Unavailable";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Porsche prices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PorscheForm_Load(object sender, EventArgs e)
        {
            LoadPorschePricesDirect(); 
        }
    }
}
