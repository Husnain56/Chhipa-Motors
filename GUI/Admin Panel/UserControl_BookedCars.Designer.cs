namespace Chhipa_Motors.GUI.Admin_Panel
{
    partial class UserControl_BookedCars
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
            dgvBookings = new DataGridView();
            btn_booking_status = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btn_booking_cancel = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // dgvBookings
            // 
            dgvBookings.BackgroundColor = SystemColors.ActiveCaption;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(33, 35);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.Size = new Size(874, 676);
            dgvBookings.TabIndex = 0;
            dgvBookings.SelectionChanged += dgv_booked_cars_SelectionChanged;
            // 
            // btn_booking_status
            // 
            btn_booking_status.BackColor = Color.Transparent;
            btn_booking_status.BadgeBackColor = Color.Red;
            btn_booking_status.BadgeForeColor = Color.White;
            btn_booking_status.BadgeRadius = 8;
            btn_booking_status.BadgeRightMargin = 10;
            btn_booking_status.BadgeValue = 0;
            btn_booking_status.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btn_booking_status.BorderColorEnd = Color.Gray;
            btn_booking_status.BorderColorStart = Color.White;
            btn_booking_status.BorderRadiusBottomLeft = 35;
            btn_booking_status.BorderRadiusBottomRight = 35;
            btn_booking_status.BorderRadiusTopLeft = 35;
            btn_booking_status.BorderRadiusTopRight = 35;
            btn_booking_status.BorderThickness = 1;
            btn_booking_status.ButtonColorEnd = Color.FromArgb(142, 50, 227);
            btn_booking_status.ButtonColorStart = Color.FromArgb(142, 50, 227);
            btn_booking_status.ButtonImage = null;
            btn_booking_status.CanBeep = false;
            btn_booking_status.CanShake = false;
            btn_booking_status.ClickSoundPath = null;
            btn_booking_status.DisabledOverlayOpacity = 0.5F;
            btn_booking_status.EnableBorderGradient = false;
            btn_booking_status.EnableClickSound = false;
            btn_booking_status.EnableFocusBorder = false;
            btn_booking_status.EnableHoverSound = false;
            btn_booking_status.EnablePressScale = false;
            btn_booking_status.EnableTextShadow = false;
            btn_booking_status.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_booking_status.FocusBorderThickness = 2;
            btn_booking_status.Font = new Font("Segoe UI", 9F);
            btn_booking_status.ForeColor = Color.White;
            btn_booking_status.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_booking_status.HoverSoundPath = null;
            btn_booking_status.HoverTransitionSpeed = 0.08F;
            btn_booking_status.ImageAlign = ContentAlignment.MiddleLeft;
            btn_booking_status.ImageLeftMargin = 5;
            btn_booking_status.ImageRightMargin = 8;
            btn_booking_status.ImageSize = 24;
            btn_booking_status.IsReadOnly = false;
            btn_booking_status.Location = new Point(941, 77);
            btn_booking_status.MakeRadial = false;
            btn_booking_status.Name = "btn_booking_status";
            btn_booking_status.PressAnimationSpeed = 0.2F;
            btn_booking_status.PressDepth = 1;
            btn_booking_status.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btn_booking_status.RippleExpandSpeedFactor = 0.05F;
            btn_booking_status.RippleFadeSpeedFactor = 0.03F;
            btn_booking_status.ShadowBlurFactor = 0.85F;
            btn_booking_status.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_booking_status.ShadowOffsetX = 3;
            btn_booking_status.ShadowOffsetY = 3;
            btn_booking_status.Size = new Size(230, 60);
            btn_booking_status.TabIndex = 2;
            btn_booking_status.Text = "siticoneButtonAdvanced2";
            btn_booking_status.TextAlign = ContentAlignment.MiddleCenter;
            btn_booking_status.TextPaddingBottom = 0;
            btn_booking_status.TextPaddingLeft = 0;
            btn_booking_status.TextPaddingRight = 0;
            btn_booking_status.TextPaddingTop = 0;
            btn_booking_status.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_booking_status.TextShadowOffsetX = 1;
            btn_booking_status.TextShadowOffsetY = 1;
            btn_booking_status.Click += btn_booking_status_Click;
            // 
            // btn_booking_cancel
            // 
            btn_booking_cancel.BackColor = Color.Transparent;
            btn_booking_cancel.BadgeBackColor = Color.Red;
            btn_booking_cancel.BadgeForeColor = Color.White;
            btn_booking_cancel.BadgeRadius = 8;
            btn_booking_cancel.BadgeRightMargin = 10;
            btn_booking_cancel.BadgeValue = 0;
            btn_booking_cancel.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btn_booking_cancel.BorderColorEnd = Color.Gray;
            btn_booking_cancel.BorderColorStart = Color.White;
            btn_booking_cancel.BorderRadiusBottomLeft = 30;
            btn_booking_cancel.BorderRadiusBottomRight = 30;
            btn_booking_cancel.BorderRadiusTopLeft = 30;
            btn_booking_cancel.BorderRadiusTopRight = 30;
            btn_booking_cancel.BorderThickness = 1;
            btn_booking_cancel.ButtonColorEnd = Color.FromArgb(142, 50, 227);
            btn_booking_cancel.ButtonColorStart = Color.FromArgb(142, 50, 227);
            btn_booking_cancel.ButtonImage = null;
            btn_booking_cancel.CanBeep = false;
            btn_booking_cancel.CanShake = false;
            btn_booking_cancel.ClickSoundPath = null;
            btn_booking_cancel.DisabledOverlayOpacity = 0.5F;
            btn_booking_cancel.EnableBorderGradient = false;
            btn_booking_cancel.EnableClickSound = false;
            btn_booking_cancel.EnableFocusBorder = false;
            btn_booking_cancel.EnableHoverSound = false;
            btn_booking_cancel.EnablePressScale = false;
            btn_booking_cancel.EnableTextShadow = false;
            btn_booking_cancel.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_booking_cancel.FocusBorderThickness = 2;
            btn_booking_cancel.Font = new Font("Segoe UI", 9F);
            btn_booking_cancel.ForeColor = Color.White;
            btn_booking_cancel.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_booking_cancel.HoverSoundPath = null;
            btn_booking_cancel.HoverTransitionSpeed = 0.08F;
            btn_booking_cancel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_booking_cancel.ImageLeftMargin = 5;
            btn_booking_cancel.ImageRightMargin = 8;
            btn_booking_cancel.ImageSize = 24;
            btn_booking_cancel.IsReadOnly = false;
            btn_booking_cancel.Location = new Point(941, 166);
            btn_booking_cancel.MakeRadial = false;
            btn_booking_cancel.Name = "btn_booking_cancel";
            btn_booking_cancel.PressAnimationSpeed = 0.2F;
            btn_booking_cancel.PressDepth = 1;
            btn_booking_cancel.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btn_booking_cancel.RippleExpandSpeedFactor = 0.05F;
            btn_booking_cancel.RippleFadeSpeedFactor = 0.03F;
            btn_booking_cancel.ShadowBlurFactor = 0.85F;
            btn_booking_cancel.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_booking_cancel.ShadowOffsetX = 3;
            btn_booking_cancel.ShadowOffsetY = 3;
            btn_booking_cancel.Size = new Size(230, 60);
            btn_booking_cancel.TabIndex = 3;
            btn_booking_cancel.Text = "siticoneButtonAdvanced3";
            btn_booking_cancel.TextAlign = ContentAlignment.MiddleCenter;
            btn_booking_cancel.TextPaddingBottom = 0;
            btn_booking_cancel.TextPaddingLeft = 0;
            btn_booking_cancel.TextPaddingRight = 0;
            btn_booking_cancel.TextPaddingTop = 0;
            btn_booking_cancel.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_booking_cancel.TextShadowOffsetX = 1;
            btn_booking_cancel.TextShadowOffsetY = 1;
            btn_booking_cancel.Click += btn_booking_cancel_Click;
            // 
            // UserControl_BookedCars
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(btn_booking_cancel);
            Controls.Add(btn_booking_status);
            Controls.Add(dgvBookings);
            Name = "UserControl_BookedCars";
            Size = new Size(1249, 745);
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBookings;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_booking_status;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_booking_cancel;
    }
}
