namespace Chhipa_Motors.GUI
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mySiticoneLicenseSettings1 = new SiticoneNetCoreUI.MySiticoneLicenseSettings();
            pnl_main = new SiticoneNetCoreUI.SiticoneContentPanel();
            pb_wallpaper = new SiticoneNetCoreUI.SiticonePictureBox();
            pb_Acc = new SiticoneNetCoreUI.SiticonePictureBox();
            lbl_ChhipaMotors_Text = new Label();
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BackColor = Color.White;
            pnl_main.ContentBackColor = Color.FromArgb(245, 245, 245);
            pnl_main.ContentPadding = new Padding(0);
            pnl_main.Controls.Add(pb_wallpaper);
            pnl_main.Controls.Add(pb_Acc);
            pnl_main.Controls.Add(lbl_ChhipaMotors_Text);
            pnl_main.DefaultTitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.EmptyContentMessageColor = Color.Gray;
            pnl_main.EmptyContentMessageFont = new Font("Segoe UI", 12F);
            pnl_main.Font = new Font("Segoe UI", 8F);
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(1594, 861);
            pnl_main.TabIndex = 0;
            pnl_main.TargetNavbar = null;
            pnl_main.TitleBackColor = Color.White;
            pnl_main.TitleForeColor = Color.FromArgb(50, 50, 50);
            pnl_main.TitlePadding = new Padding(20, 0, 20, 0);
            pnl_main.TitleSeparatorColor = Color.Silver;
            // 
            // pb_wallpaper
            // 
            pb_wallpaper.BackColor = Color.FromArgb(30, 30, 30);
            pb_wallpaper.BorderColor = Color.FromArgb(40, 40, 40);
            pb_wallpaper.BorderWidth = 1;
            pb_wallpaper.Brightness = 1F;
            pb_wallpaper.Contrast = 1F;
            pb_wallpaper.CornerRadius = 10;
            pb_wallpaper.DraggingSpeed = 3.15F;
            pb_wallpaper.EnableAsyncLoading = false;
            pb_wallpaper.EnableCaching = false;
            pb_wallpaper.EnableDragDrop = false;
            pb_wallpaper.EnableExtendedImageSources = false;
            pb_wallpaper.EnableFilters = false;
            pb_wallpaper.EnableFlipping = false;
            pb_wallpaper.EnableGlow = false;
            pb_wallpaper.EnableHighDpiSupport = false;
            pb_wallpaper.EnableMouseInteraction = false;
            pb_wallpaper.EnablePlaceholder = false;
            pb_wallpaper.EnableRotation = false;
            pb_wallpaper.EnableShadow = true;
            pb_wallpaper.EnableSlideshow = false;
            pb_wallpaper.FlipHorizontal = false;
            pb_wallpaper.FlipVertical = false;
            pb_wallpaper.Grayscale = false;
            pb_wallpaper.Image = (Image)resources.GetObject("pb_wallpaper.Image");
            pb_wallpaper.ImageOpacity = 1F;
            pb_wallpaper.Images = (List<Image>)resources.GetObject("pb_wallpaper.Images");
            pb_wallpaper.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_wallpaper.IsCircular = false;
            pb_wallpaper.Location = new Point(3, 0);
            pb_wallpaper.MaintainAspectRatio = true;
            pb_wallpaper.Name = "pb_wallpaper";
            pb_wallpaper.PlaceholderImage = null;
            pb_wallpaper.RotationAngle = 0F;
            pb_wallpaper.Saturation = 1F;
            pb_wallpaper.ShowBorder = false;
            pb_wallpaper.Size = new Size(1594, 828);
            pb_wallpaper.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.CenterImage;
            pb_wallpaper.TabIndex = 3;
            pb_wallpaper.Text = "siticonePictureBox1";
            // 
            // pb_Acc
            // 
            pb_Acc.BackColor = Color.Transparent;
            pb_Acc.BorderColor = Color.FromArgb(40, 40, 40);
            pb_Acc.BorderWidth = 1;
            pb_Acc.Brightness = 1F;
            pb_Acc.Contrast = 1F;
            pb_Acc.CornerRadius = 10;
            pb_Acc.DraggingSpeed = 3.15F;
            pb_Acc.EnableAsyncLoading = false;
            pb_Acc.EnableCaching = false;
            pb_Acc.EnableDragDrop = false;
            pb_Acc.EnableExtendedImageSources = false;
            pb_Acc.EnableFilters = false;
            pb_Acc.EnableFlipping = false;
            pb_Acc.EnableGlow = false;
            pb_Acc.EnableHighDpiSupport = false;
            pb_Acc.EnableMouseInteraction = false;
            pb_Acc.EnablePlaceholder = false;
            pb_Acc.EnableRotation = false;
            pb_Acc.EnableShadow = true;
            pb_Acc.EnableSlideshow = false;
            pb_Acc.FlipHorizontal = false;
            pb_Acc.FlipVertical = false;
            pb_Acc.Grayscale = false;
            pb_Acc.Image = (Image)resources.GetObject("pb_Acc.Image");
            pb_Acc.ImageOpacity = 1F;
            pb_Acc.Images = (List<Image>)resources.GetObject("pb_Acc.Images");
            pb_Acc.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_Acc.IsCircular = false;
            pb_Acc.Location = new Point(1505, 33);
            pb_Acc.MaintainAspectRatio = true;
            pb_Acc.Name = "pb_Acc";
            pb_Acc.PlaceholderImage = null;
            pb_Acc.RotationAngle = 0F;
            pb_Acc.Saturation = 1F;
            pb_Acc.ShowBorder = true;
            pb_Acc.Size = new Size(29, 30);
            pb_Acc.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Zoom;
            pb_Acc.TabIndex = 6;
            // 
            // lbl_ChhipaMotors_Text
            // 
            lbl_ChhipaMotors_Text.AutoSize = true;
            lbl_ChhipaMotors_Text.BackColor = Color.Transparent;
            lbl_ChhipaMotors_Text.Font = new Font("Castellar", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ChhipaMotors_Text.ForeColor = Color.White;
            lbl_ChhipaMotors_Text.Location = new Point(658, 33);
            lbl_ChhipaMotors_Text.Name = "lbl_ChhipaMotors_Text";
            lbl_ChhipaMotors_Text.Size = new Size(364, 42);
            lbl_ChhipaMotors_Text.TabIndex = 2;
            lbl_ChhipaMotors_Text.Text = "Chhipa Motors";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 861);
            Controls.Add(pnl_main);
            Name = "MainForm";
            Text = "MainForm";
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private SiticoneNetCoreUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private SiticoneNetCoreUI.SiticoneContentPanel pnl_main;
        private SiticoneNetCoreUI.SiticonePictureBox pb_wallpaper;
        private Label lbl_ChhipaMotors_Text;
        private SiticoneNetCoreUI.SiticonePictureBox pb_Acc;
    }
}

