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
using Chhipa_Motors.BL;
using Chhipa_Motors.DTO;

namespace Chhipa_Motors.GUI.Car_Cards
{
    public partial class UserControl_Lamborghini : UserControl
    {
        private CarBL _carBL;

        public UserControl_Lamborghini()
        {
            InitializeComponent();
            _carBL = new CarBL();
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

        private void UserControl_Lamborghini_Load(object sender, EventArgs e)
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

            // Load Lamborghini prices and availability
            LoadLamborghiniPricesDirect();
        }

        private void LoadLamborghiniPricesDirect()
        {
            try
            {
                var lamborghiniCars = _carBL.GetCarsByManufacturer("Lamborghini");

                var carLookup = new Dictionary<string, (SiticoneLabel priceLabel, SiticoneButtonAdvanced bookButton)>
                {
                    { "Urus SE", (lbl_p_UrusSE, btn_book_UrusSE) },
                    { "Urus Performance", (lbl_p_UrusPerformance, btn_book_UrusP) },
                    { "Temerario", (lbl_p_Temerario, btn_book_Temerario) },
                    { "Revuelto", (btn_p_revuelto, btn_book_Revuelto) }
                };

                foreach (var car in lamborghiniCars)
                {
                    if (carLookup.ContainsKey(car.CarName))
                    {
                        var (priceLabel, bookButton) = carLookup[car.CarName];

                        // Update price label
                        decimal price = decimal.Parse(car.Price);
                        priceLabel.Text = $"{price:N0}";
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
                MessageBox.Show($"Error loading Lamborghini prices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}