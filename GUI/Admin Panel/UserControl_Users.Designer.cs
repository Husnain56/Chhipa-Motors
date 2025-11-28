namespace Chhipa_Motors.GUI.Admin_Panel
{
    partial class UserControl_Users
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_deleteUser = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            radioButton_Admins = new SiticoneNetCoreUI.SiticoneRadioButton();
            radioButton_Users = new SiticoneNetCoreUI.SiticoneRadioButton();
            radioButton_Customers = new SiticoneNetCoreUI.SiticoneRadioButton();
            dgv_users = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_users).BeginInit();
            SuspendLayout();
            // 
            // btn_deleteUser
            // 
            btn_deleteUser.BackColor = Color.Transparent;
            btn_deleteUser.BadgeBackColor = Color.Red;
            btn_deleteUser.BadgeForeColor = Color.White;
            btn_deleteUser.BadgeRadius = 8;
            btn_deleteUser.BadgeRightMargin = 10;
            btn_deleteUser.BadgeValue = 0;
            btn_deleteUser.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btn_deleteUser.BorderColorEnd = Color.Gray;
            btn_deleteUser.BorderColorStart = Color.White;
            btn_deleteUser.BorderRadiusBottomLeft = 35;
            btn_deleteUser.BorderRadiusBottomRight = 35;
            btn_deleteUser.BorderRadiusTopLeft = 35;
            btn_deleteUser.BorderRadiusTopRight = 35;
            btn_deleteUser.BorderThickness = 1;
            btn_deleteUser.ButtonColorEnd = Color.FromArgb(142, 50, 227);
            btn_deleteUser.ButtonColorStart = Color.FromArgb(142, 50, 227);
            btn_deleteUser.ButtonImage = null;
            btn_deleteUser.CanBeep = false;
            btn_deleteUser.CanShake = false;
            btn_deleteUser.ClickSoundPath = null;
            btn_deleteUser.DisabledOverlayOpacity = 0.5F;
            btn_deleteUser.EnableBorderGradient = false;
            btn_deleteUser.EnableClickSound = false;
            btn_deleteUser.EnableFocusBorder = false;
            btn_deleteUser.EnableHoverSound = false;
            btn_deleteUser.EnablePressScale = false;
            btn_deleteUser.EnableTextShadow = false;
            btn_deleteUser.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_deleteUser.FocusBorderThickness = 2;
            btn_deleteUser.Font = new Font("Segoe UI", 9F);
            btn_deleteUser.ForeColor = Color.White;
            btn_deleteUser.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_deleteUser.HoverSoundPath = null;
            btn_deleteUser.HoverTransitionSpeed = 0.08F;
            btn_deleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btn_deleteUser.ImageLeftMargin = 5;
            btn_deleteUser.ImageRightMargin = 8;
            btn_deleteUser.ImageSize = 24;
            btn_deleteUser.IsReadOnly = false;
            btn_deleteUser.Location = new Point(930, 184);
            btn_deleteUser.MakeRadial = false;
            btn_deleteUser.Name = "btn_deleteUser";
            btn_deleteUser.PressAnimationSpeed = 0.2F;
            btn_deleteUser.PressDepth = 1;
            btn_deleteUser.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btn_deleteUser.RippleExpandSpeedFactor = 0.05F;
            btn_deleteUser.RippleFadeSpeedFactor = 0.03F;
            btn_deleteUser.ShadowBlurFactor = 0.85F;
            btn_deleteUser.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_deleteUser.ShadowOffsetX = 3;
            btn_deleteUser.ShadowOffsetY = 3;
            btn_deleteUser.Size = new Size(202, 65);
            btn_deleteUser.TabIndex = 4;
            btn_deleteUser.Text = "Delete User";
            btn_deleteUser.TextAlign = ContentAlignment.MiddleCenter;
            btn_deleteUser.TextPaddingBottom = 0;
            btn_deleteUser.TextPaddingLeft = 0;
            btn_deleteUser.TextPaddingRight = 0;
            btn_deleteUser.TextPaddingTop = 0;
            btn_deleteUser.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_deleteUser.TextShadowOffsetX = 1;
            btn_deleteUser.TextShadowOffsetY = 1;
            btn_deleteUser.UltraPerformanceMode = true;
            btn_deleteUser.Click += btn_deleteUser_Click;
            // 
            // radioButton_Admins
            // 
            radioButton_Admins.AccessibleName = "";
            radioButton_Admins.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_Admins.BackColor = Color.Transparent;
            radioButton_Admins.CanBeep = true;
            radioButton_Admins.CanShake = true;
            radioButton_Admins.Checked = true;
            radioButton_Admins.CheckedColor = Color.White;
            radioButton_Admins.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_Admins.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_Admins.ContainerBorderWidth = 1;
            radioButton_Admins.ContainerBottomLeftRadius = 8;
            radioButton_Admins.ContainerBottomRightRadius = 8;
            radioButton_Admins.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_Admins.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_Admins.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_Admins.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_Admins.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_Admins.ContainerPadding = 8;
            radioButton_Admins.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_Admins.ContainerTopLeftRadius = 8;
            radioButton_Admins.ContainerTopRightRadius = 8;
            radioButton_Admins.ContextMenu = null;
            radioButton_Admins.EnableRipple = true;
            radioButton_Admins.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_Admins.HoverCursor = Cursors.Hand;
            radioButton_Admins.IsContained = false;
            radioButton_Admins.IsReadOnly = false;
            radioButton_Admins.Location = new Point(95, 32);
            radioButton_Admins.MinimumSize = new Size(178, 32);
            radioButton_Admins.Name = "radioButton_Admins";
            radioButton_Admins.RippleColor = Color.LightGray;
            radioButton_Admins.RippleDuration = 0.5F;
            radioButton_Admins.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_Admins.ShakeDuration = 0.5F;
            radioButton_Admins.Size = new Size(196, 42);
            radioButton_Admins.TabIndex = 5;
            radioButton_Admins.Text = "Admins";
            radioButton_Admins.TextColor = Color.White;
            radioButton_Admins.ToolTipText = "";
            radioButton_Admins.UncheckedColor = Color.White;
            radioButton_Admins.CheckedChanged += radioButton_Admins_CheckedChanged;
            // 
            // radioButton_Users
            // 
            radioButton_Users.AccessibleName = "Users";
            radioButton_Users.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_Users.BackColor = Color.Transparent;
            radioButton_Users.CanBeep = true;
            radioButton_Users.CanShake = true;
            radioButton_Users.Checked = false;
            radioButton_Users.CheckedColor = Color.White;
            radioButton_Users.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_Users.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_Users.ContainerBorderWidth = 1;
            radioButton_Users.ContainerBottomLeftRadius = 8;
            radioButton_Users.ContainerBottomRightRadius = 8;
            radioButton_Users.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_Users.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_Users.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_Users.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_Users.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_Users.ContainerPadding = 8;
            radioButton_Users.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_Users.ContainerTopLeftRadius = 8;
            radioButton_Users.ContainerTopRightRadius = 8;
            radioButton_Users.ContextMenu = null;
            radioButton_Users.EnableRipple = true;
            radioButton_Users.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_Users.HoverCursor = Cursors.Hand;
            radioButton_Users.IsContained = false;
            radioButton_Users.IsReadOnly = false;
            radioButton_Users.Location = new Point(361, 32);
            radioButton_Users.MinimumSize = new Size(178, 32);
            radioButton_Users.Name = "radioButton_Users";
            radioButton_Users.RippleColor = Color.LightGray;
            radioButton_Users.RippleDuration = 0.5F;
            radioButton_Users.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_Users.ShakeDuration = 0.5F;
            radioButton_Users.Size = new Size(196, 42);
            radioButton_Users.TabIndex = 6;
            radioButton_Users.Text = "Users";
            radioButton_Users.TextColor = Color.White;
            radioButton_Users.ToolTipText = "";
            radioButton_Users.UncheckedColor = Color.White;
            radioButton_Users.CheckedChanged += radioButton_Users_CheckedChanged;
            // 
            // radioButton_Customers
            // 
            radioButton_Customers.AccessibleName = "Customers";
            radioButton_Customers.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_Customers.BackColor = Color.Transparent;
            radioButton_Customers.CanBeep = true;
            radioButton_Customers.CanShake = true;
            radioButton_Customers.Checked = false;
            radioButton_Customers.CheckedColor = Color.White;
            radioButton_Customers.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_Customers.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_Customers.ContainerBorderWidth = 1;
            radioButton_Customers.ContainerBottomLeftRadius = 8;
            radioButton_Customers.ContainerBottomRightRadius = 8;
            radioButton_Customers.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_Customers.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_Customers.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_Customers.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_Customers.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_Customers.ContainerPadding = 8;
            radioButton_Customers.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_Customers.ContainerTopLeftRadius = 8;
            radioButton_Customers.ContainerTopRightRadius = 8;
            radioButton_Customers.ContextMenu = null;
            radioButton_Customers.EnableRipple = true;
            radioButton_Customers.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_Customers.HoverCursor = Cursors.Hand;
            radioButton_Customers.IsContained = false;
            radioButton_Customers.IsReadOnly = false;
            radioButton_Customers.Location = new Point(633, 32);
            radioButton_Customers.MinimumSize = new Size(178, 32);
            radioButton_Customers.Name = "radioButton_Customers";
            radioButton_Customers.RippleColor = Color.LightGray;
            radioButton_Customers.RippleDuration = 0.5F;
            radioButton_Customers.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_Customers.ShakeDuration = 0.5F;
            radioButton_Customers.Size = new Size(196, 42);
            radioButton_Customers.TabIndex = 7;
            radioButton_Customers.Text = "Customers";
            radioButton_Customers.TextColor = Color.White;
            radioButton_Customers.ToolTipText = "";
            radioButton_Customers.UncheckedColor = Color.White;
            radioButton_Customers.CheckedChanged += radioButton_Customers_CheckedChanged;
            // 
            // dgv_users
            // 
            dgv_users.BackgroundColor = Color.DarkSlateBlue;
            dgv_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_users.GridColor = Color.FromArgb(0, 0, 64);
            dgv_users.Location = new Point(45, 116);
            dgv_users.Name = "dgv_users";
            dgv_users.RowHeadersWidth = 50;
            dgv_users.Size = new Size(860, 535);
            dgv_users.TabIndex = 8;
            // 
            // UserControl_Users
            // 
            AccessibleDescription = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(dgv_users);
            Controls.Add(radioButton_Customers);
            Controls.Add(radioButton_Users);
            Controls.Add(radioButton_Admins);
            Controls.Add(btn_deleteUser);
            Name = "UserControl_Users";
            Size = new Size(1157, 720);
            ((System.ComponentModel.ISupportInitialize)dgv_users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_deleteUser;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_Admins;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_Users;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_Customers;
        private DataGridView dgv_users;
    }
}
