namespace Chhipa_Motors.GUI.Admin_Panel
{
    partial class UserControl_ViewCars
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
            dgv_cars = new DataGridView();
            btn_update_price = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btn_update_stock = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            btn_change_status = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            ((System.ComponentModel.ISupportInitialize)dgv_cars).BeginInit();
            SuspendLayout();
            // 
            // dgv_cars
            // 
            dgv_cars.BackgroundColor = Color.DarkSlateBlue;
            dgv_cars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cars.Location = new Point(25, 51);
            dgv_cars.Name = "dgv_cars";
            dgv_cars.Size = new Size(854, 615);
            dgv_cars.TabIndex = 0;
            dgv_cars.SelectionChanged += dgv_cars_SelectionChanged;
            // 
            // btn_update_price
            // 
            btn_update_price.BackColor = Color.Transparent;
            btn_update_price.BadgeBackColor = Color.Red;
            btn_update_price.BadgeForeColor = Color.White;
            btn_update_price.BadgeRadius = 8;
            btn_update_price.BadgeRightMargin = 10;
            btn_update_price.BadgeValue = 0;
            btn_update_price.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btn_update_price.BorderColorEnd = Color.Gray;
            btn_update_price.BorderColorStart = Color.White;
            btn_update_price.BorderRadiusBottomLeft = 35;
            btn_update_price.BorderRadiusBottomRight = 35;
            btn_update_price.BorderRadiusTopLeft = 35;
            btn_update_price.BorderRadiusTopRight = 35;
            btn_update_price.BorderThickness = 1;
            btn_update_price.ButtonColorEnd = Color.FromArgb(142, 50, 227);
            btn_update_price.ButtonColorStart = Color.FromArgb(142, 50, 227);
            btn_update_price.ButtonImage = null;
            btn_update_price.CanBeep = false;
            btn_update_price.CanShake = false;
            btn_update_price.ClickSoundPath = null;
            btn_update_price.DisabledOverlayOpacity = 0.5F;
            btn_update_price.EnableBorderGradient = false;
            btn_update_price.EnableClickSound = false;
            btn_update_price.EnableFocusBorder = false;
            btn_update_price.EnableHoverSound = false;
            btn_update_price.EnablePressScale = false;
            btn_update_price.EnableTextShadow = false;
            btn_update_price.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_update_price.FocusBorderThickness = 2;
            btn_update_price.Font = new Font("Segoe UI", 9F);
            btn_update_price.ForeColor = Color.White;
            btn_update_price.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_update_price.HoverSoundPath = null;
            btn_update_price.HoverTransitionSpeed = 0.08F;
            btn_update_price.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update_price.ImageLeftMargin = 5;
            btn_update_price.ImageRightMargin = 8;
            btn_update_price.ImageSize = 24;
            btn_update_price.IsReadOnly = false;
            btn_update_price.Location = new Point(885, 83);
            btn_update_price.MakeRadial = false;
            btn_update_price.Name = "btn_update_price";
            btn_update_price.PressAnimationSpeed = 0.2F;
            btn_update_price.PressDepth = 1;
            btn_update_price.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btn_update_price.RippleExpandSpeedFactor = 0.05F;
            btn_update_price.RippleFadeSpeedFactor = 0.03F;
            btn_update_price.ShadowBlurFactor = 0.85F;
            btn_update_price.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_update_price.ShadowOffsetX = 3;
            btn_update_price.ShadowOffsetY = 3;
            btn_update_price.Size = new Size(230, 60);
            btn_update_price.TabIndex = 1;
            btn_update_price.Text = "Update Price";
            btn_update_price.TextAlign = ContentAlignment.MiddleCenter;
            btn_update_price.TextPaddingBottom = 0;
            btn_update_price.TextPaddingLeft = 0;
            btn_update_price.TextPaddingRight = 0;
            btn_update_price.TextPaddingTop = 0;
            btn_update_price.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_update_price.TextShadowOffsetX = 1;
            btn_update_price.TextShadowOffsetY = 1;
            btn_update_price.Click += btn_update_price_Click;
            // 
            // btn_update_stock
            // 
            btn_update_stock.BackColor = Color.Transparent;
            btn_update_stock.BadgeBackColor = Color.Red;
            btn_update_stock.BadgeForeColor = Color.White;
            btn_update_stock.BadgeRadius = 8;
            btn_update_stock.BadgeRightMargin = 10;
            btn_update_stock.BadgeValue = 0;
            btn_update_stock.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btn_update_stock.BorderColorEnd = Color.Gray;
            btn_update_stock.BorderColorStart = Color.White;
            btn_update_stock.BorderRadiusBottomLeft = 35;
            btn_update_stock.BorderRadiusBottomRight = 35;
            btn_update_stock.BorderRadiusTopLeft = 35;
            btn_update_stock.BorderRadiusTopRight = 35;
            btn_update_stock.BorderThickness = 1;
            btn_update_stock.ButtonColorEnd = Color.FromArgb(142, 50, 227);
            btn_update_stock.ButtonColorStart = Color.FromArgb(142, 50, 227);
            btn_update_stock.ButtonImage = null;
            btn_update_stock.CanBeep = false;
            btn_update_stock.CanShake = false;
            btn_update_stock.ClickSoundPath = null;
            btn_update_stock.DisabledOverlayOpacity = 0.5F;
            btn_update_stock.EnableBorderGradient = false;
            btn_update_stock.EnableClickSound = false;
            btn_update_stock.EnableFocusBorder = false;
            btn_update_stock.EnableHoverSound = false;
            btn_update_stock.EnablePressScale = false;
            btn_update_stock.EnableTextShadow = false;
            btn_update_stock.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_update_stock.FocusBorderThickness = 2;
            btn_update_stock.Font = new Font("Segoe UI", 9F);
            btn_update_stock.ForeColor = Color.White;
            btn_update_stock.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_update_stock.HoverSoundPath = null;
            btn_update_stock.HoverTransitionSpeed = 0.08F;
            btn_update_stock.ImageAlign = ContentAlignment.MiddleLeft;
            btn_update_stock.ImageLeftMargin = 5;
            btn_update_stock.ImageRightMargin = 8;
            btn_update_stock.ImageSize = 24;
            btn_update_stock.IsReadOnly = false;
            btn_update_stock.Location = new Point(885, 177);
            btn_update_stock.MakeRadial = false;
            btn_update_stock.Name = "btn_update_stock";
            btn_update_stock.PressAnimationSpeed = 0.2F;
            btn_update_stock.PressDepth = 1;
            btn_update_stock.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btn_update_stock.RippleExpandSpeedFactor = 0.05F;
            btn_update_stock.RippleFadeSpeedFactor = 0.03F;
            btn_update_stock.ShadowBlurFactor = 0.85F;
            btn_update_stock.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_update_stock.ShadowOffsetX = 3;
            btn_update_stock.ShadowOffsetY = 3;
            btn_update_stock.Size = new Size(230, 60);
            btn_update_stock.TabIndex = 2;
            btn_update_stock.Text = "Update Stock";
            btn_update_stock.TextAlign = ContentAlignment.MiddleCenter;
            btn_update_stock.TextPaddingBottom = 0;
            btn_update_stock.TextPaddingLeft = 0;
            btn_update_stock.TextPaddingRight = 0;
            btn_update_stock.TextPaddingTop = 0;
            btn_update_stock.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_update_stock.TextShadowOffsetX = 1;
            btn_update_stock.TextShadowOffsetY = 1;
            btn_update_stock.Click += btn_update_stock_Click;
            // 
            // btn_change_status
            // 
            btn_change_status.BackColor = Color.Transparent;
            btn_change_status.BadgeBackColor = Color.Red;
            btn_change_status.BadgeForeColor = Color.White;
            btn_change_status.BadgeRadius = 8;
            btn_change_status.BadgeRightMargin = 10;
            btn_change_status.BadgeValue = 0;
            btn_change_status.BorderColor = Color.FromArgb(150, 255, 255, 255);
            btn_change_status.BorderColorEnd = Color.Gray;
            btn_change_status.BorderColorStart = Color.White;
            btn_change_status.BorderRadiusBottomLeft = 35;
            btn_change_status.BorderRadiusBottomRight = 35;
            btn_change_status.BorderRadiusTopLeft = 35;
            btn_change_status.BorderRadiusTopRight = 35;
            btn_change_status.BorderThickness = 1;
            btn_change_status.ButtonColorEnd = Color.FromArgb(142, 50, 227);
            btn_change_status.ButtonColorStart = Color.FromArgb(142, 50, 227);
            btn_change_status.ButtonImage = null;
            btn_change_status.CanBeep = false;
            btn_change_status.CanShake = false;
            btn_change_status.ClickSoundPath = null;
            btn_change_status.DisabledOverlayOpacity = 0.5F;
            btn_change_status.EnableBorderGradient = false;
            btn_change_status.EnableClickSound = false;
            btn_change_status.EnableFocusBorder = false;
            btn_change_status.EnableHoverSound = false;
            btn_change_status.EnablePressScale = false;
            btn_change_status.EnableTextShadow = false;
            btn_change_status.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_change_status.FocusBorderThickness = 2;
            btn_change_status.Font = new Font("Segoe UI", 9F);
            btn_change_status.ForeColor = Color.White;
            btn_change_status.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_change_status.HoverSoundPath = null;
            btn_change_status.HoverTransitionSpeed = 0.08F;
            btn_change_status.ImageAlign = ContentAlignment.MiddleLeft;
            btn_change_status.ImageLeftMargin = 5;
            btn_change_status.ImageRightMargin = 8;
            btn_change_status.ImageSize = 24;
            btn_change_status.IsReadOnly = false;
            btn_change_status.Location = new Point(885, 269);
            btn_change_status.MakeRadial = false;
            btn_change_status.Name = "btn_change_status";
            btn_change_status.PressAnimationSpeed = 0.2F;
            btn_change_status.PressDepth = 1;
            btn_change_status.RippleColor = Color.FromArgb(60, 255, 255, 255);
            btn_change_status.RippleExpandSpeedFactor = 0.05F;
            btn_change_status.RippleFadeSpeedFactor = 0.03F;
            btn_change_status.ShadowBlurFactor = 0.85F;
            btn_change_status.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_change_status.ShadowOffsetX = 3;
            btn_change_status.ShadowOffsetY = 3;
            btn_change_status.Size = new Size(230, 60);
            btn_change_status.TabIndex = 3;
            btn_change_status.Text = "Pause Availability";
            btn_change_status.TextAlign = ContentAlignment.MiddleCenter;
            btn_change_status.TextPaddingBottom = 0;
            btn_change_status.TextPaddingLeft = 0;
            btn_change_status.TextPaddingRight = 0;
            btn_change_status.TextPaddingTop = 0;
            btn_change_status.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_change_status.TextShadowOffsetX = 1;
            btn_change_status.TextShadowOffsetY = 1;
            btn_change_status.Click += btn_change_status_Click;
            // 
            // UserControl_ViewCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(btn_change_status);
            Controls.Add(btn_update_stock);
            Controls.Add(btn_update_price);
            Controls.Add(dgv_cars);
            Name = "UserControl_ViewCars";
            Size = new Size(1157, 720);
            ((System.ComponentModel.ISupportInitialize)dgv_cars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_cars;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_update_price;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_update_stock;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_change_status;
    }
}
