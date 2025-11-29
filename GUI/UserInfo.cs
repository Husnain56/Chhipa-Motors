using Chhipa_Motors.BL;
using Chhipa_Motors.DTO;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Chhipa_Motors.GUI
{
    public partial class UserInfo : UserControl
    {
        private CustomerBL _CustomerBL;
        private UserDTO _userDTO;
        private Panel headerPanel;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel profilePanel;
        private Panel updatePanel;
        private Label lblCurrentName;
        private Label lblCurrentEmail;
        private Label lblCurrentPhone;
        private TextBox txt_input;
        private TextBox txt_pass;
        private Button btn_up_name;
        private Button btn_up_email;
        private Button btn_up_phone;
        private Button btn_confirm;
        private Button btn_cancel;
        private string currentUpdateField = "";

        public UserInfo(string userId)
        {
            _CustomerBL = new CustomerBL();
            _userDTO = new UserDTO();
            _userDTO.Id = userId;

            this.Dock = DockStyle.Fill;
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = Color.FromArgb(245, 247, 250);

            InitializeCustomComponents();
            LoadUserInfo();
        }

        private void InitializeCustomComponents()
        {
            this.Size = new Size(1100, 740);

            // Header Panel with gradient
            headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                BackColor = Color.FromArgb(102, 126, 234)
            };
            headerPanel.Paint += HeaderPanel_Paint;

            // Title
            lblTitle = new Label
            {
                Text = "Account Information",
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 25)
            };

            // Subtitle
            lblSubtitle = new Label
            {
                Text = "View and update your personal information",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 85)
            };

            headerPanel.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            // Profile Information Panel
            profilePanel = new Panel
            {
                Location = new Point(40, 160),
                Size = new Size(480, 380),
                BackColor = Color.White,
                Padding = new Padding(30)
            };
            profilePanel.Paint += ProfilePanel_Paint;

            // Profile Title
            Label lblProfileTitle = new Label
            {
                Text = "Profile Details",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                AutoSize = true,
                Location = new Point(30, 20)
            };

            // Username Section
            CreateInfoSection("Username:", ref lblCurrentName, 80, profilePanel);
            btn_up_name = CreateUpdateButton("Edit Username", 380, 78);
            btn_up_name.Click += btn_up_name_Click;

            // Email Section
            CreateInfoSection("Email Address:", ref lblCurrentEmail, 170, profilePanel);
            btn_up_email = CreateUpdateButton("Edit Email", 380, 168);
            btn_up_email.Click += btn_up_email_Click;

            // Phone Section
            CreateInfoSection("Phone Number:", ref lblCurrentPhone, 260, profilePanel);
            btn_up_phone = CreateUpdateButton("Edit Phone", 380, 258);
            btn_up_phone.Click += btn_up_phone_Click;

            profilePanel.Controls.Add(lblProfileTitle);
            profilePanel.Controls.AddRange(new Control[] {
                btn_up_name, btn_up_email, btn_up_phone
            });

            // Update Information Panel
            updatePanel = new Panel
            {
                Location = new Point(560, 160),
                Size = new Size(480, 380),
                BackColor = Color.White,
                Padding = new Padding(30),
                Visible = false
            };
            updatePanel.Paint += ProfilePanel_Paint;

            // Update Title
            Label lblUpdateTitle = new Label
            {
                Text = "Update Information",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                AutoSize = true,
                Location = new Point(30, 20)
            };

            // New Value Label
            Label lblNewValue = new Label
            {
                Text = "New Value:",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 80, 80),
                AutoSize = true,
                Location = new Point(30, 80)
            };

            // Input Textbox
            txt_input = new TextBox
            {
                Location = new Point(30, 110),
                Size = new Size(420, 40),
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Password Label
            Label lblPassword = new Label
            {
                Text = "Confirm Password:",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 80, 80),
                AutoSize = true,
                Location = new Point(30, 170)
            };

            // Password Textbox
            txt_pass = new TextBox
            {
                Location = new Point(30, 200),
                Size = new Size(420, 40),
                Font = new Font("Segoe UI", 12),
                BorderStyle = BorderStyle.FixedSingle,
                UseSystemPasswordChar = true
            };

            // Info Label
            Label lblInfo = new Label
            {
                Text = "Please enter your password to confirm changes",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.FromArgb(120, 120, 120),
                AutoSize = true,
                Location = new Point(30, 250)
            };

            // Confirm Button
            btn_confirm = new GradientButton
            {
                Text = "✓ CONFIRM UPDATE",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(30, 300),
                Size = new Size(200, 50),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btn_confirm.FlatAppearance.BorderSize = 0;
            btn_confirm.Click += btn_confirm_Click;

            // Cancel Button
            btn_cancel = new Button
            {
                Text = "✕ CANCEL",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(102, 126, 234),
                Location = new Point(250, 300),
                Size = new Size(200, 50),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btn_cancel.FlatAppearance.BorderColor = Color.FromArgb(102, 126, 234);
            btn_cancel.FlatAppearance.BorderSize = 2;
            btn_cancel.Click += btn_cancel_Click;
            btn_cancel.MouseEnter += (s, e) => btn_cancel.BackColor = Color.FromArgb(240, 243, 250);
            btn_cancel.MouseLeave += (s, e) => btn_cancel.BackColor = Color.White;

            updatePanel.Controls.AddRange(new Control[] {
                lblUpdateTitle, lblNewValue, txt_input, lblPassword, txt_pass,
                lblInfo, btn_confirm, btn_cancel
            });

            // Add all panels to form
            this.Controls.AddRange(new Control[] { headerPanel, profilePanel, updatePanel });
        }

        private void CreateInfoSection(string labelText, ref Label valueLabel, int yPosition, Panel parentPanel)
        {
            Label lblField = new Label
            {
                Text = labelText,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(80, 80, 80),
                AutoSize = true,
                Location = new Point(30, yPosition)
            };

            valueLabel = new Label
            {
                Text = "Loading...",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.FromArgb(51, 51, 51),
                AutoSize = true,
                Location = new Point(30, yPosition + 25),
                MaximumSize = new Size(340, 0)
            };

            parentPanel.Controls.Add(lblField);
            parentPanel.Controls.Add(valueLabel);
        }

        private Button CreateUpdateButton(string text, int x, int y)
        {
            Button btn = new Button
            {
                Text = text,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(102, 126, 234),
                Location = new Point(x, y),
                Size = new Size(100, 30),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = Color.White
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(102, 126, 234);
            btn.FlatAppearance.BorderSize = 1;
            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(240, 243, 250);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.White;

            return btn;
        }

        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                headerPanel.ClientRectangle,
                Color.FromArgb(102, 126, 234),
                Color.FromArgb(118, 75, 162),
                45f))
            {
                e.Graphics.FillRectangle(brush, headerPanel.ClientRectangle);
            }
        }

        private void ProfilePanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Draw shadow
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(10, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(shadowBrush, 2, 2, panel.Width - 2, panel.Height - 2);
            }

            // Draw rounded rectangle
            using (GraphicsPath path = GetRoundedRectPath(new Rectangle(0, 0, panel.Width - 1, panel.Height - 1), 8))
            {
                using (SolidBrush brush = new SolidBrush(panel.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.FromArgb(220, 220, 220), 1))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void LoadUserInfo()
        {
            try
            {
                // TODO: Implement backend logic to load user information
                // Example:
                // UserDTO user = _userBL.GetUserById(_userDTO.Id);
                // if (user != null)
                // {
                //     lblCurrentName.Text = user.Username;
                //     lblCurrentEmail.Text = user.Email;
                //     lblCurrentPhone.Text = user.PhoneNumber;
                // }

                // Temporary placeholder data
                lblCurrentName.Text = "john_doe";
                lblCurrentEmail.Text = "john.doe@example.com";
                lblCurrentPhone.Text = "+92 300 1234567";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_up_name_Click(object sender, EventArgs e)
        {
            ShowUpdatePanel("Username");
            txt_input.PlaceholderText = "Enter new Username";
            currentUpdateField = "Username";
        }

        private void btn_up_email_Click(object sender, EventArgs e)
        {
            ShowUpdatePanel("Email");
            txt_input.PlaceholderText = "Enter new Email";
            currentUpdateField = "Email";
        }

        private void btn_up_phone_Click(object sender, EventArgs e)
        {
            ShowUpdatePanel("Phone");
            txt_input.PlaceholderText = "Enter new Phone Number";
            currentUpdateField = "Phone";
        }

        private void ShowUpdatePanel(string fieldName)
        {
            updatePanel.Visible = true;
            txt_input.Text = "";
            txt_pass.Text = "";
            txt_input.Focus();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            updatePanel.Visible = false;
            txt_input.Text = "";
            txt_pass.Text = "";
            currentUpdateField = "";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txt_input.Text) || string.IsNullOrWhiteSpace(txt_pass.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Additional validation based on field type
            if (currentUpdateField == "Email" && !IsValidEmail(txt_input.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (currentUpdateField == "Phone" && !IsValidPhone(txt_input.Text))
            {
                MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // TODO: Implement backend logic to verify password and update information
                // Example:
                // _userDTO.Password = txt_pass.Text;
                // bool passwordValid = _userBL.VerifyPassword(_userDTO);
                // 
                // if (!passwordValid)
                // {
                //     MessageBox.Show("Incorrect password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //     return;
                // }
                //
                // switch (currentUpdateField)
                // {
                //     case "Username":
                //         _userDTO.Username = txt_input.Text;
                //         break;
                //     case "Email":
                //         _userDTO.Email = txt_input.Text;
                //         break;
                //     case "Phone":
                //         _userDTO.PhoneNumber = txt_input.Text;
                //         break;
                // }
                //
                // int result = _userBL.UpdateUserInfo(_userDTO);
                // if (result > 0)
                // {
                //     MessageBox.Show($"{currentUpdateField} updated successfully!", "Success",
                //         MessageBoxButtons.OK, MessageBoxIcon.Information);
                //     LoadUserInfo();
                //     btn_cancel_Click(null, null);
                // }

                // Temporary success message
                MessageBox.Show($"{currentUpdateField} updated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUserInfo();
                btn_cancel_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating information: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Remove spaces and dashes
            string cleanPhone = phone.Replace(" ", "").Replace("-", "").Replace("+", "");
            // Check if it contains only digits and is at least 10 characters
            return cleanPhone.All(char.IsDigit) && cleanPhone.Length >= 10;
        }
    }

    // Custom Gradient Button (reuse from previous code)
    public class GradientButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Color startColor = this.Enabled ?
                Color.FromArgb(102, 126, 234) : Color.Gray;
            Color endColor = this.Enabled ?
                Color.FromArgb(118, 75, 162) : Color.DarkGray;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                startColor,
                endColor,
                45f))
            {
                e.Graphics.FillRoundedRectangle(brush, 0, 0, Width, Height, 8);
            }

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font,
                this.ClientRectangle, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    // Extension method for rounded rectangles
    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush,
            float x, float y, float width, float height, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, radius, radius, 180, 90);
            path.AddArc(x + width - radius, y, radius, radius, 270, 90);
            path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
            path.AddArc(x, y + height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            graphics.FillPath(brush, path);
            path.Dispose();
        }
    }
}