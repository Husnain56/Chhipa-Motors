using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Chhipa_Motors.GUI.LoginGUI
{
    public partial class LoginForm : Form
    {
        private Panel leftPanel;
        private Panel rightPanel;
        private Label lblLogo;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private RadioButton rbUser;
        private RadioButton rbAdmin;
        private Label lblUserType;
        private LinkLabel lnkCreateAccount;

        public LoginForm()
        {
            InitializeComponent();
            InitializeButton();
        }
        private void InitializeButton()
        {
            this.Text = "Chhipa Motors - Login";
            this.Size = new Size(900, 550);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;

            leftPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 400,
                BackColor = Color.FromArgb(102, 126, 234)
            };
            leftPanel.Paint += LeftPanel_Paint;

            lblLogo = new Label
            {
                Text = "🚗",
                Font = new Font("Segoe UI", 60, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(150, 80)
            };

            lblWelcome = new Label
            {
                Text = "Chhipa Motors",
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(80, 180)
            };

            lblSubtitle = new Label
            {
                Text = "Your trusted partner in finding\nthe perfect vehicle",
                Font = new Font("Segoe UI", 14),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(75, 240),
                TextAlign = ContentAlignment.MiddleCenter
            };

            leftPanel.Controls.AddRange(new Control[] { lblLogo, lblWelcome, lblSubtitle });

            rightPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(60, 80, 60, 80)
            };

            Label lblTitle = new Label
            {
                Text = "Welcome Back!",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                AutoSize = true,
                Location = new Point(60, 50)
            };

            Label lblDesc = new Label
            {
                Text = "Please login to continue",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(60, 95)
            };

            lblUserType = new Label
            {
                Text = "Login as:",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(60, 140),
                AutoSize = true
            };

            rbUser = new RadioButton
            {
                Text = "Customer",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(102, 126, 234),
                Location = new Point(60, 170),
                AutoSize = true,
                Checked = true
            };

            rbAdmin = new RadioButton
            {
                Text = "Administrator",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.FromArgb(102, 126, 234),
                Location = new Point(180, 170),
                AutoSize = true
            };

            lblUsername = new Label
            {
                Text = "Username",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(60, 220),
                AutoSize = true
            };

            txtUsername = new RoundedTextBox
            {
                Font = new Font("Segoe UI", 12),
                Location = new Point(60, 250),
                Size = new Size(360, 40),
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.None,
                Padding = new Padding(10)
            };

            lblPassword = new Label
            {
                Text = "Password",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(60, 310),
                AutoSize = true
            };

            txtPassword = new RoundedTextBox
            {
                Font = new Font("Segoe UI", 12),
                Location = new Point(60, 340),
                Size = new Size(360, 40),
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.None,
                PasswordChar = '●',
                Padding = new Padding(10)
            };

            btnLogin = new GradientButton
            {
                Text = "LOGIN",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(60, 400),
                Size = new Size(360, 50),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Click += BtnLogin_Click;

            lnkCreateAccount = new LinkLabel
            {
                Text = "Don't have an account? Create one",
                Font = new Font("Segoe UI", 10),
                LinkColor = Color.FromArgb(102, 126, 234),
                Location = new Point(110, 465),
                AutoSize = true
            };
            lnkCreateAccount.Click += LnkCreateAccount_Click;

            rightPanel.Controls.AddRange(new Control[] {
            lblTitle, lblDesc, lblUserType, rbUser, rbAdmin,
            lblUsername, txtUsername, lblPassword, txtPassword,
            btnLogin, lnkCreateAccount
        });

            this.Controls.Add(rightPanel);
            this.Controls.Add(leftPanel);

            Button btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.FromArgb(200, 200, 200),
                Location = new Point(this.Width - 50, 10),
                Size = new Size(40, 40),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = Color.Transparent
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 240, 240);
            btnClose.MouseEnter += (s, e) => btnClose.ForeColor = Color.Red;
            btnClose.MouseLeave += (s, e) => btnClose.ForeColor = Color.FromArgb(200, 200, 200);
            btnClose.Click += (s, e) => Application.Exit();
            this.Controls.Add(btnClose);
            btnClose.BringToFront();
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {
            // Gradient background
            using (LinearGradientBrush brush = new LinearGradientBrush(
                leftPanel.ClientRectangle,
                Color.FromArgb(102, 126, 234),
                Color.FromArgb(118, 75, 162),
                45f))
            {
                e.Graphics.FillRectangle(brush, leftPanel.ClientRectangle);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TODO: Add your authentication logic here
            // Example:
            // UserDAL userDAL = new UserDAL();
            // User user = userDAL.ValidateLogin(username, password);

            if (rbAdmin.Checked)
            {
                // TODO: Validate admin credentials
                // if (user != null && user.Role == "Admin")
                // {
                MessageBox.Show("Admin login successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Admin Panel
                // AdminPanel adminPanel = new AdminPanel();
                // adminPanel.Show();
                // this.Hide();
                // }
            }
            else
            {
                // TODO: Validate user credentials
                // if (user != null)
                // {
                MessageBox.Show("User login successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Home Screen
                // HomeScreen homeScreen = new HomeScreen();
                // homeScreen.Show();
                // this.Hide();
                // }
            }
        }

        private void LnkCreateAccount_Click(object sender, EventArgs e)
        {
            using (RegisterDialog registerDialog = new RegisterDialog())
            {
                if (registerDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Account created successfully! You can now login.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }

    public class RoundedTextBox : TextBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0xF) // WM_PAINT
            {
                using (Graphics g = Graphics.FromHwnd(Handle))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen pen = new Pen(Color.FromArgb(224, 224, 224), 2))
                    {
                        g.DrawRectangle(pen, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
        }
    }

    public class GradientButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(102, 126, 234),
                Color.FromArgb(118, 75, 162),
                45f))
            {
                e.Graphics.FillRoundedRectangle(brush, 0, 0, Width, Height, 10);
            }

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font,
                this.ClientRectangle, this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    public static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics graphics, Brush brush,
            int x, int y, int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(x, y, radius, radius, 180, 90);
            path.AddArc(x + width - radius, y, radius, radius, 270, 90);
            path.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
            path.AddArc(x, y + height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            graphics.FillPath(brush, path);
        }
    }

    public class RegisterDialog : Form
    {
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnCancel;

        public string Username => txtUsername.Text.Trim();
        public string Password => txtPassword.Text.Trim();

        public RegisterDialog()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Form settings
            this.Text = "Create New Account";
            this.Size = new Size(450, 450);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = Color.White;

            lblTitle = new Label
            {
                Text = "Create Account",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.FromArgb(102, 126, 234),
                Location = new Point(30, 30),
                AutoSize = true
            };

            lblUsername = new Label
            {
                Text = "Username",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 100),
                AutoSize = true
            };

            txtUsername = new TextBox
            {
                Font = new Font("Segoe UI", 12),
                Location = new Point(30, 130),
                Size = new Size(380, 35),
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle
            };

            lblPassword = new Label
            {
                Text = "Password",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 185),
                AutoSize = true
            };

            txtPassword = new TextBox
            {
                Font = new Font("Segoe UI", 12),
                Location = new Point(30, 215),
                Size = new Size(380, 35),
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle,
                PasswordChar = '●'
            };

            lblConfirmPassword = new Label
            {
                Text = "Confirm Password",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 270),
                AutoSize = true
            };

            txtConfirmPassword = new TextBox
            {
                Font = new Font("Segoe UI", 12),
                Location = new Point(30, 300),
                Size = new Size(380, 35),
                BackColor = Color.FromArgb(245, 245, 245),
                BorderStyle = BorderStyle.FixedSingle,
                PasswordChar = '●'
            };

            btnRegister = new GradientButton
            {
                Text = "CREATE ACCOUNT",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(30, 360),
                Size = new Size(180, 40),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Click += BtnRegister_Click;

            btnCancel = new Button
            {
                Text = "CANCEL",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.Gray,
                Location = new Point(230, 360),
                Size = new Size(180, 40),
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = Color.FromArgb(240, 240, 240)
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            this.Controls.AddRange(new Control[] {
            lblTitle, lblUsername, txtUsername,
            lblPassword, txtPassword,
            lblConfirmPassword, txtConfirmPassword,
            btnRegister, btnCancel
        });
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            // TODO: Add your user registration logic here
            // Example:
            // UserDAL userDAL = new UserDAL();
            // bool success = userDAL.RegisterUser(username, password, "User");
            // if (success)
            // {
            //     this.DialogResult = DialogResult.OK;
            // }

            // For now, just close with OK
            this.DialogResult = DialogResult.OK;
        }
    }
}