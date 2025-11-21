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
            lbl_msg = new SiticoneNetCoreUI.SiticoneShimmerLabel();
            pb_MacLaren_mf = new SiticoneNetCoreUI.SiticonePictureBox();
            pb_porsche_mf = new SiticoneNetCoreUI.SiticonePictureBox();
            container_menu = new SiticoneNetCoreUI.SiticoneSplitContainer();
            btn_menu_purchases_list = new SiticoneNetCoreUI.SiticoneDashboardButton();
            btn_menu_manufacturer_list = new SiticoneNetCoreUI.SiticoneDashboardButton();
            btn_menu_acc = new SiticoneNetCoreUI.SiticoneDashboardButton();
            btn_menu_services_list = new SiticoneNetCoreUI.SiticoneDashboardButton();
            btn_close_menu = new SiticoneNetCoreUI.SiticoneButton();
            pb_blur_screen = new SiticoneNetCoreUI.SiticonePictureBox();
            btn_menu = new SiticoneNetCoreUI.SiticoneButtonAdvanced();
            pb_nissan_mf = new SiticoneNetCoreUI.SiticonePictureBox();
            pb_lambo_mf = new SiticoneNetCoreUI.SiticonePictureBox();
            pb_porsche_logo = new SiticoneNetCoreUI.SiticonePictureBox();
            pb_Acc = new SiticoneNetCoreUI.SiticonePictureBox();
            pb_wallpaper = new SiticoneNetCoreUI.SiticonePictureBox();
            pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)container_menu).BeginInit();
            container_menu.Panel1.SuspendLayout();
            container_menu.Panel2.SuspendLayout();
            container_menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.AutoScroll = true;
            pnl_main.BackColor = Color.Black;
            pnl_main.ContentBackColor = Color.Black;
            pnl_main.ContentPadding = new Padding(0);
            pnl_main.Controls.Add(lbl_msg);
            pnl_main.Controls.Add(pb_MacLaren_mf);
            pnl_main.Controls.Add(pb_porsche_mf);
            pnl_main.Controls.Add(container_menu);
            pnl_main.Controls.Add(pb_blur_screen);
            pnl_main.Controls.Add(btn_menu);
            pnl_main.Controls.Add(pb_nissan_mf);
            pnl_main.Controls.Add(pb_lambo_mf);
            pnl_main.Controls.Add(pb_porsche_logo);
            pnl_main.Controls.Add(pb_Acc);
            pnl_main.Controls.Add(pb_wallpaper);
            pnl_main.DefaultTitleFont = new Font("Segoe UI", 10F, FontStyle.Bold);
            pnl_main.Dock = DockStyle.Fill;
            pnl_main.EmptyContentMessageColor = Color.Gray;
            pnl_main.EmptyContentMessageFont = new Font("Segoe UI", 12F);
            pnl_main.Font = new Font("Segoe UI", 8F);
            pnl_main.Location = new Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new Size(1350, 729);
            pnl_main.TabIndex = 0;
            pnl_main.TargetNavbar = null;
            pnl_main.TitleBackColor = Color.White;
            pnl_main.TitleForeColor = Color.FromArgb(50, 50, 50);
            pnl_main.TitlePadding = new Padding(20, 0, 20, 0);
            pnl_main.TitleSeparatorColor = Color.Silver;
            // 
            // lbl_msg
            // 
            lbl_msg.AutoReverse = false;
            lbl_msg.BaseColor = Color.White;
            lbl_msg.Direction = SiticoneNetCoreUI.ShimmerDirection.LeftToRight;
            lbl_msg.Font = new Font("Modern No. 20", 47.9999924F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_msg.IsAnimating = true;
            lbl_msg.IsPaused = false;
            lbl_msg.Location = new Point(0, 787);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.PauseDuration = 0;
            lbl_msg.ShimmerColor = Color.Cyan;
            lbl_msg.ShimmerOpacity = 1F;
            lbl_msg.ShimmerSpeed = 50;
            lbl_msg.ShimmerWidth = 0.2F;
            lbl_msg.Size = new Size(1176, 79);
            lbl_msg.TabIndex = 30;
            lbl_msg.Text = "The Ride to Your Next Car Starts Here";
            lbl_msg.ToolTipText = "";
            // 
            // pb_MacLaren_mf
            // 
            pb_MacLaren_mf.BackColor = Color.White;
            pb_MacLaren_mf.BorderColor = Color.Black;
            pb_MacLaren_mf.BorderWidth = 1;
            pb_MacLaren_mf.Brightness = 1F;
            pb_MacLaren_mf.Contrast = 1F;
            pb_MacLaren_mf.CornerRadius = 0;
            pb_MacLaren_mf.DraggingSpeed = 3.15F;
            pb_MacLaren_mf.EnableAsyncLoading = false;
            pb_MacLaren_mf.EnableCaching = false;
            pb_MacLaren_mf.EnableDragDrop = false;
            pb_MacLaren_mf.EnableExtendedImageSources = false;
            pb_MacLaren_mf.EnableFilters = false;
            pb_MacLaren_mf.EnableFlipping = false;
            pb_MacLaren_mf.EnableGlow = false;
            pb_MacLaren_mf.EnableHighDpiSupport = false;
            pb_MacLaren_mf.EnableMouseInteraction = false;
            pb_MacLaren_mf.EnablePlaceholder = false;
            pb_MacLaren_mf.EnableRotation = false;
            pb_MacLaren_mf.EnableShadow = false;
            pb_MacLaren_mf.EnableSlideshow = false;
            pb_MacLaren_mf.FlipHorizontal = false;
            pb_MacLaren_mf.FlipVertical = false;
            pb_MacLaren_mf.Grayscale = false;
            pb_MacLaren_mf.Image = (Image)resources.GetObject("pb_MacLaren_mf.Image");
            pb_MacLaren_mf.ImageOpacity = 1F;
            pb_MacLaren_mf.Images = (List<Image>)resources.GetObject("pb_MacLaren_mf.Images");
            pb_MacLaren_mf.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_MacLaren_mf.IsCircular = false;
            pb_MacLaren_mf.Location = new Point(690, 960);
            pb_MacLaren_mf.MaintainAspectRatio = true;
            pb_MacLaren_mf.Name = "pb_MacLaren_mf";
            pb_MacLaren_mf.PlaceholderImage = null;
            pb_MacLaren_mf.RotationAngle = 0F;
            pb_MacLaren_mf.Saturation = 1F;
            pb_MacLaren_mf.ShowBorder = true;
            pb_MacLaren_mf.Size = new Size(545, 466);
            pb_MacLaren_mf.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            pb_MacLaren_mf.TabIndex = 15;
            pb_MacLaren_mf.Text = "siticonePictureBox2";
            pb_MacLaren_mf.MouseEnter += pb_mf_MouseEnter;
            pb_MacLaren_mf.MouseLeave += pb_mf_MouseLeave;
            // 
            // pb_porsche_mf
            // 
            pb_porsche_mf.BackColor = Color.White;
            pb_porsche_mf.BorderColor = Color.Black;
            pb_porsche_mf.BorderWidth = 1;
            pb_porsche_mf.Brightness = 1F;
            pb_porsche_mf.Contrast = 1F;
            pb_porsche_mf.CornerRadius = 0;
            pb_porsche_mf.DraggingSpeed = 3.15F;
            pb_porsche_mf.EnableAsyncLoading = false;
            pb_porsche_mf.EnableCaching = false;
            pb_porsche_mf.EnableDragDrop = false;
            pb_porsche_mf.EnableExtendedImageSources = false;
            pb_porsche_mf.EnableFilters = false;
            pb_porsche_mf.EnableFlipping = false;
            pb_porsche_mf.EnableGlow = false;
            pb_porsche_mf.EnableHighDpiSupport = false;
            pb_porsche_mf.EnableMouseInteraction = false;
            pb_porsche_mf.EnablePlaceholder = false;
            pb_porsche_mf.EnableRotation = false;
            pb_porsche_mf.EnableShadow = false;
            pb_porsche_mf.EnableSlideshow = false;
            pb_porsche_mf.FlipHorizontal = false;
            pb_porsche_mf.FlipVertical = false;
            pb_porsche_mf.Grayscale = false;
            pb_porsche_mf.Image = (Image)resources.GetObject("pb_porsche_mf.Image");
            pb_porsche_mf.ImageOpacity = 1F;
            pb_porsche_mf.Images = (List<Image>)resources.GetObject("pb_porsche_mf.Images");
            pb_porsche_mf.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_porsche_mf.IsCircular = false;
            pb_porsche_mf.Location = new Point(100, 960);
            pb_porsche_mf.MaintainAspectRatio = true;
            pb_porsche_mf.Name = "pb_porsche_mf";
            pb_porsche_mf.PlaceholderImage = null;
            pb_porsche_mf.RotationAngle = 0F;
            pb_porsche_mf.Saturation = 1F;
            pb_porsche_mf.ShowBorder = true;
            pb_porsche_mf.Size = new Size(545, 466);
            pb_porsche_mf.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            pb_porsche_mf.TabIndex = 14;
            pb_porsche_mf.Text = "siticonePictureBox1";
            pb_porsche_mf.MouseEnter += pb_mf_MouseEnter;
            pb_porsche_mf.MouseLeave += pb_mf_MouseLeave;
            // 
            // container_menu
            // 
            container_menu.AccessibleDescription = "Allows resizing of two panels using a movable splitter";
            container_menu.AccessibleName = "Split Container";
            container_menu.AccessibleRole = AccessibleRole.Pane;
            container_menu.AnimationInterval = 1000;
            container_menu.AnimationStep = 1000;
            container_menu.AspectRatio = 1F;
            container_menu.AutoHideDelay = 2000;
            container_menu.BackColor = Color.FromArgb(45, 45, 48);
            container_menu.CollapseThreshold = 10;
            container_menu.DragUpdateInterval = 16;
            container_menu.EnableAnimatedSplitter = true;
            container_menu.EnableAutoHide = false;
            container_menu.EnableDynamicResizing = true;
            container_menu.EnableHotkeys = true;
            container_menu.EnableKeyboardNavigation = true;
            container_menu.EnablePanelCollapse = false;
            container_menu.EnablePanelReordering = false;
            container_menu.EnableSmoothDrag = true;
            container_menu.EnableSnapping = false;
            container_menu.EnableSplitterHighlight = false;
            container_menu.EnableSplitterLock = false;
            container_menu.EnableStateManagement = true;
            container_menu.IsSplitterLocked = false;
            container_menu.Location = new Point(0, 0);
            container_menu.MaintainAspectRatio = false;
            container_menu.Name = "container_menu";
            // 
            // container_menu.Panel1
            // 
            container_menu.Panel1.AccessibleName = "pnl_options";
            container_menu.Panel1.BackColor = Color.Black;
            container_menu.Panel1.Controls.Add(btn_menu_purchases_list);
            container_menu.Panel1.Controls.Add(btn_menu_manufacturer_list);
            container_menu.Panel1.Controls.Add(btn_menu_acc);
            container_menu.Panel1.Controls.Add(btn_menu_services_list);
            container_menu.Panel1Title = "Panel 1";
            // 
            // container_menu.Panel2
            // 
            container_menu.Panel2.AccessibleName = "pnl_results";
            container_menu.Panel2.AutoScroll = true;
            container_menu.Panel2.BackColor = Color.Black;
            container_menu.Panel2.Controls.Add(btn_close_menu);
            container_menu.Panel2Title = "Panel 2";
            container_menu.ShowPanelHeaders = false;
            container_menu.Size = new Size(1089, 716);
            container_menu.SnapDistance = 20;
            container_menu.SnapPositions = new float[]
    {
    0.25F,
    0.5F,
    0.75F
    };
            container_menu.SplitterCursor = Cursors.VSplit;
            container_menu.SplitterDistance = 362;
            container_menu.SplitterHighlightColor = Color.FromArgb(0, 122, 204);
            container_menu.SplitterMoveable = true;
            container_menu.SplitterMoveLeftKey = Keys.Left;
            container_menu.SplitterMoveRightKey = Keys.Right;
            container_menu.SplitterPositionKey = "EnhancedSplitContainer_SplitterPosition";
            container_menu.SplitterTexture = null;
            container_menu.SwapPanelsHotkey = Keys.Control | Keys.Alt | Keys.S;
            container_menu.TabIndex = 26;
            container_menu.ToggleOrientationHotkey = Keys.Control | Keys.Alt | Keys.O;
            // 
            // btn_menu_purchases_list
            // 
            btn_menu_purchases_list.AccessibilityDescription = "";
            btn_menu_purchases_list.AccessibleDescription = "Button ";
            btn_menu_purchases_list.AccessibleName = "";
            btn_menu_purchases_list.AccessibleRole = AccessibleRole.PushButton;
            btn_menu_purchases_list.AnimationSpeed = 0.09F;
            btn_menu_purchases_list.BackColor = Color.Transparent;
            btn_menu_purchases_list.BadgeColor = Color.FromArgb(239, 68, 68);
            btn_menu_purchases_list.BadgeCount = 0;
            btn_menu_purchases_list.BadgePadding = 8;
            btn_menu_purchases_list.BadgeSize = 20;
            btn_menu_purchases_list.BadgeTextColor = Color.White;
            btn_menu_purchases_list.CornerRadiusBottomLeft = 8;
            btn_menu_purchases_list.CornerRadiusBottomRight = 8;
            btn_menu_purchases_list.CornerRadiusTopLeft = 8;
            btn_menu_purchases_list.CornerRadiusTopRight = 8;
            btn_menu_purchases_list.DescriptionColor = SystemColors.Highlight;
            btn_menu_purchases_list.DescriptionFont = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_purchases_list.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_purchases_list.GradientEndColor = Color.FromArgb(0, 200, 255);
            btn_menu_purchases_list.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btn_menu_purchases_list.GradientStartColor = Color.FromArgb(41, 121, 255);
            btn_menu_purchases_list.HoverColor = Color.FromArgb(45, 45, 45);
            btn_menu_purchases_list.ImageSize = new Size(24, 24);
            btn_menu_purchases_list.IndicatorColor = Color.White;
            btn_menu_purchases_list.IndicatorGradientColor = Color.White;
            btn_menu_purchases_list.IndicatorWidth = 3;
            btn_menu_purchases_list.IsAccessibilityEnabled = true;
            btn_menu_purchases_list.IsSelected = false;
            btn_menu_purchases_list.Location = new Point(55, 170);
            btn_menu_purchases_list.Name = "btn_menu_purchases_list";
            btn_menu_purchases_list.NormalColor = Color.DarkGray;
            btn_menu_purchases_list.PressColor = Color.FromArgb(30, 30, 30);
            btn_menu_purchases_list.RippleColor = Color.White;
            btn_menu_purchases_list.SelectedColor = Color.DimGray;
            btn_menu_purchases_list.SelectedDescriptionColor = Color.LightGray;
            btn_menu_purchases_list.SelectedTextColor = Color.White;
            btn_menu_purchases_list.ShowBadge = false;
            btn_menu_purchases_list.Size = new Size(250, 57);
            btn_menu_purchases_list.TabIndex = 2;
            btn_menu_purchases_list.Text = "Purchase History";
            btn_menu_purchases_list.TextColor = Color.White;
            btn_menu_purchases_list.UseGradientBackground = false;
            // 
            // btn_menu_manufacturer_list
            // 
            btn_menu_manufacturer_list.AccessibilityDescription = "";
            btn_menu_manufacturer_list.AccessibleDescription = "Button ";
            btn_menu_manufacturer_list.AccessibleName = "";
            btn_menu_manufacturer_list.AccessibleRole = AccessibleRole.PushButton;
            btn_menu_manufacturer_list.AnimationSpeed = 0.09F;
            btn_menu_manufacturer_list.BackColor = Color.Transparent;
            btn_menu_manufacturer_list.BadgeColor = Color.FromArgb(239, 68, 68);
            btn_menu_manufacturer_list.BadgeCount = 0;
            btn_menu_manufacturer_list.BadgePadding = 8;
            btn_menu_manufacturer_list.BadgeSize = 20;
            btn_menu_manufacturer_list.BadgeTextColor = Color.White;
            btn_menu_manufacturer_list.CornerRadiusBottomLeft = 8;
            btn_menu_manufacturer_list.CornerRadiusBottomRight = 8;
            btn_menu_manufacturer_list.CornerRadiusTopLeft = 8;
            btn_menu_manufacturer_list.CornerRadiusTopRight = 8;
            btn_menu_manufacturer_list.DescriptionColor = SystemColors.Highlight;
            btn_menu_manufacturer_list.DescriptionFont = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_manufacturer_list.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_manufacturer_list.GradientEndColor = Color.FromArgb(0, 200, 255);
            btn_menu_manufacturer_list.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btn_menu_manufacturer_list.GradientStartColor = Color.FromArgb(41, 121, 255);
            btn_menu_manufacturer_list.HoverColor = Color.FromArgb(45, 45, 45);
            btn_menu_manufacturer_list.ImageSize = new Size(24, 24);
            btn_menu_manufacturer_list.IndicatorColor = Color.White;
            btn_menu_manufacturer_list.IndicatorGradientColor = Color.White;
            btn_menu_manufacturer_list.IndicatorWidth = 3;
            btn_menu_manufacturer_list.IsAccessibilityEnabled = true;
            btn_menu_manufacturer_list.IsSelected = false;
            btn_menu_manufacturer_list.Location = new Point(55, 77);
            btn_menu_manufacturer_list.Name = "btn_menu_manufacturer_list";
            btn_menu_manufacturer_list.NormalColor = Color.DarkGray;
            btn_menu_manufacturer_list.PressColor = Color.FromArgb(30, 30, 30);
            btn_menu_manufacturer_list.RippleColor = Color.White;
            btn_menu_manufacturer_list.SelectedColor = Color.DimGray;
            btn_menu_manufacturer_list.SelectedDescriptionColor = Color.LightGray;
            btn_menu_manufacturer_list.SelectedTextColor = Color.White;
            btn_menu_manufacturer_list.ShowBadge = false;
            btn_menu_manufacturer_list.Size = new Size(250, 57);
            btn_menu_manufacturer_list.TabIndex = 1;
            btn_menu_manufacturer_list.Text = "Manufacturers";
            btn_menu_manufacturer_list.TextColor = Color.White;
            btn_menu_manufacturer_list.UseGradientBackground = false;
            btn_menu_manufacturer_list.Click += btn_menu_manufacturer_list_Click;
            // 
            // btn_menu_acc
            // 
            btn_menu_acc.AccessibilityDescription = "";
            btn_menu_acc.AccessibleDescription = "Button ";
            btn_menu_acc.AccessibleName = "";
            btn_menu_acc.AccessibleRole = AccessibleRole.PushButton;
            btn_menu_acc.AnimationSpeed = 0.09F;
            btn_menu_acc.BackColor = Color.Transparent;
            btn_menu_acc.BadgeColor = Color.FromArgb(239, 68, 68);
            btn_menu_acc.BadgeCount = 0;
            btn_menu_acc.BadgePadding = 8;
            btn_menu_acc.BadgeSize = 20;
            btn_menu_acc.BadgeTextColor = Color.White;
            btn_menu_acc.CornerRadiusBottomLeft = 8;
            btn_menu_acc.CornerRadiusBottomRight = 8;
            btn_menu_acc.CornerRadiusTopLeft = 8;
            btn_menu_acc.CornerRadiusTopRight = 8;
            btn_menu_acc.DescriptionColor = SystemColors.Highlight;
            btn_menu_acc.DescriptionFont = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_acc.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_acc.GradientEndColor = Color.FromArgb(0, 200, 255);
            btn_menu_acc.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btn_menu_acc.GradientStartColor = Color.FromArgb(41, 121, 255);
            btn_menu_acc.HoverColor = Color.FromArgb(45, 45, 45);
            btn_menu_acc.ImageSize = new Size(24, 24);
            btn_menu_acc.IndicatorColor = Color.White;
            btn_menu_acc.IndicatorGradientColor = Color.White;
            btn_menu_acc.IndicatorWidth = 3;
            btn_menu_acc.IsAccessibilityEnabled = true;
            btn_menu_acc.IsSelected = false;
            btn_menu_acc.Location = new Point(55, 552);
            btn_menu_acc.Name = "btn_menu_acc";
            btn_menu_acc.NormalColor = Color.DarkGray;
            btn_menu_acc.PressColor = Color.FromArgb(30, 30, 30);
            btn_menu_acc.RippleColor = Color.White;
            btn_menu_acc.SelectedColor = Color.DimGray;
            btn_menu_acc.SelectedDescriptionColor = Color.LightGray;
            btn_menu_acc.SelectedTextColor = Color.White;
            btn_menu_acc.ShowBadge = false;
            btn_menu_acc.Size = new Size(250, 57);
            btn_menu_acc.TabIndex = 4;
            btn_menu_acc.Text = "Account";
            btn_menu_acc.TextColor = Color.White;
            btn_menu_acc.UseGradientBackground = false;
            btn_menu_acc.Click += btn_menu_acc_Click;
            // 
            // btn_menu_services_list
            // 
            btn_menu_services_list.AccessibilityDescription = "";
            btn_menu_services_list.AccessibleDescription = "Button ";
            btn_menu_services_list.AccessibleName = "";
            btn_menu_services_list.AccessibleRole = AccessibleRole.PushButton;
            btn_menu_services_list.AnimationSpeed = 0.09F;
            btn_menu_services_list.BackColor = Color.Transparent;
            btn_menu_services_list.BadgeColor = Color.FromArgb(239, 68, 68);
            btn_menu_services_list.BadgeCount = 0;
            btn_menu_services_list.BadgePadding = 8;
            btn_menu_services_list.BadgeSize = 20;
            btn_menu_services_list.BadgeTextColor = Color.White;
            btn_menu_services_list.CornerRadiusBottomLeft = 8;
            btn_menu_services_list.CornerRadiusBottomRight = 8;
            btn_menu_services_list.CornerRadiusTopLeft = 8;
            btn_menu_services_list.CornerRadiusTopRight = 8;
            btn_menu_services_list.DescriptionColor = SystemColors.Highlight;
            btn_menu_services_list.DescriptionFont = new Font("Lucida Fax", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_services_list.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu_services_list.GradientEndColor = Color.FromArgb(0, 200, 255);
            btn_menu_services_list.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            btn_menu_services_list.GradientStartColor = Color.FromArgb(41, 121, 255);
            btn_menu_services_list.HoverColor = Color.FromArgb(45, 45, 45);
            btn_menu_services_list.ImageSize = new Size(24, 24);
            btn_menu_services_list.IndicatorColor = Color.White;
            btn_menu_services_list.IndicatorGradientColor = Color.White;
            btn_menu_services_list.IndicatorWidth = 3;
            btn_menu_services_list.IsAccessibilityEnabled = true;
            btn_menu_services_list.IsSelected = false;
            btn_menu_services_list.Location = new Point(55, 262);
            btn_menu_services_list.Name = "btn_menu_services_list";
            btn_menu_services_list.NormalColor = Color.DarkGray;
            btn_menu_services_list.PressColor = Color.FromArgb(30, 30, 30);
            btn_menu_services_list.RippleColor = Color.White;
            btn_menu_services_list.SelectedColor = Color.DimGray;
            btn_menu_services_list.SelectedDescriptionColor = Color.LightGray;
            btn_menu_services_list.SelectedTextColor = Color.White;
            btn_menu_services_list.ShowBadge = false;
            btn_menu_services_list.Size = new Size(250, 57);
            btn_menu_services_list.TabIndex = 3;
            btn_menu_services_list.Text = "Services";
            btn_menu_services_list.TextColor = Color.White;
            btn_menu_services_list.UseGradientBackground = false;
            // 
            // btn_close_menu
            // 
            btn_close_menu.AccessibleDescription = "The default button control that accept input though the mouse, touch and keyboard";
            btn_close_menu.AccessibleName = "X";
            btn_close_menu.AutoSizeBasedOnText = false;
            btn_close_menu.BackColor = Color.Transparent;
            btn_close_menu.BadgeBackColor = Color.Black;
            btn_close_menu.BadgeFont = new Font("Segoe UI", 8F, FontStyle.Bold);
            btn_close_menu.BadgeValue = 0;
            btn_close_menu.BadgeValueForeColor = Color.White;
            btn_close_menu.BorderColor = Color.FromArgb(213, 216, 220);
            btn_close_menu.BorderWidth = 1;
            btn_close_menu.ButtonBackColor = Color.FromArgb(245, 247, 250);
            btn_close_menu.ButtonImage = null;
            btn_close_menu.ButtonTextLeftPadding = 0;
            btn_close_menu.CanBeep = true;
            btn_close_menu.CanGlow = false;
            btn_close_menu.CanShake = true;
            btn_close_menu.ContextMenuStripEx = null;
            btn_close_menu.CornerRadiusBottomLeft = 6;
            btn_close_menu.CornerRadiusBottomRight = 6;
            btn_close_menu.CornerRadiusTopLeft = 6;
            btn_close_menu.CornerRadiusTopRight = 6;
            btn_close_menu.CustomCursor = Cursors.Default;
            btn_close_menu.DisabledTextColor = Color.FromArgb(150, 150, 150);
            btn_close_menu.EnableLongPress = false;
            btn_close_menu.EnableRippleEffect = true;
            btn_close_menu.EnableShadow = false;
            btn_close_menu.EnableTextWrapping = false;
            btn_close_menu.Font = new Font("Segoe UI Semibold", 10.2F);
            btn_close_menu.GlowColor = Color.FromArgb(100, 255, 255, 255);
            btn_close_menu.GlowIntensity = 100;
            btn_close_menu.GlowRadius = 20F;
            btn_close_menu.GradientBackground = false;
            btn_close_menu.GradientColor = Color.FromArgb(0, 227, 64);
            btn_close_menu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            btn_close_menu.HintText = null;
            btn_close_menu.HoverBackColor = Color.FromArgb(240, 240, 240);
            btn_close_menu.HoverFontStyle = FontStyle.Regular;
            btn_close_menu.HoverTextColor = Color.FromArgb(0, 0, 0);
            btn_close_menu.HoverTransitionDuration = 250;
            btn_close_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_close_menu.ImagePadding = 5;
            btn_close_menu.ImageSize = new Size(16, 16);
            btn_close_menu.IsRadial = false;
            btn_close_menu.IsReadOnly = false;
            btn_close_menu.IsToggleButton = false;
            btn_close_menu.IsToggled = false;
            btn_close_menu.Location = new Point(669, 32);
            btn_close_menu.LongPressDurationMS = 1000;
            btn_close_menu.Name = "btn_close_menu";
            btn_close_menu.NormalFontStyle = FontStyle.Regular;
            btn_close_menu.ParticleColor = Color.FromArgb(200, 200, 200);
            btn_close_menu.ParticleCount = 15;
            btn_close_menu.PressAnimationScale = 0.97F;
            btn_close_menu.PressedBackColor = Color.FromArgb(225, 227, 230);
            btn_close_menu.PressedFontStyle = FontStyle.Regular;
            btn_close_menu.PressTransitionDuration = 150;
            btn_close_menu.ReadOnlyTextColor = Color.FromArgb(100, 100, 100);
            btn_close_menu.RippleColor = Color.FromArgb(0, 0, 0);
            btn_close_menu.RippleRadiusMultiplier = 0.6F;
            btn_close_menu.ShadowBlur = 5;
            btn_close_menu.ShadowColor = Color.FromArgb(30, 0, 0, 0);
            btn_close_menu.ShadowOffset = new Point(0, 2);
            btn_close_menu.ShakeDuration = 500;
            btn_close_menu.ShakeIntensity = 5;
            btn_close_menu.Size = new Size(31, 35);
            btn_close_menu.TabIndex = 30;
            btn_close_menu.Text = "X";
            btn_close_menu.TextAlign = ContentAlignment.MiddleCenter;
            btn_close_menu.TextColor = Color.FromArgb(0, 0, 0);
            btn_close_menu.TooltipText = null;
            btn_close_menu.UseAdvancedRendering = true;
            btn_close_menu.UseParticles = false;
            btn_close_menu.Click += btn_close_menu_Click_1;
            // 
            // pb_blur_screen
            // 
            pb_blur_screen.BackColor = Color.FromArgb(30, 30, 30);
            pb_blur_screen.BorderColor = Color.FromArgb(40, 40, 40);
            pb_blur_screen.BorderWidth = 1;
            pb_blur_screen.Brightness = 1F;
            pb_blur_screen.Contrast = 1F;
            pb_blur_screen.CornerRadius = 10;
            pb_blur_screen.DraggingSpeed = 3.15F;
            pb_blur_screen.EnableAsyncLoading = false;
            pb_blur_screen.EnableCaching = false;
            pb_blur_screen.EnableDragDrop = false;
            pb_blur_screen.EnableExtendedImageSources = false;
            pb_blur_screen.EnableFilters = false;
            pb_blur_screen.EnableFlipping = false;
            pb_blur_screen.EnableGlow = false;
            pb_blur_screen.EnableHighDpiSupport = false;
            pb_blur_screen.EnableMouseInteraction = false;
            pb_blur_screen.EnablePlaceholder = false;
            pb_blur_screen.EnableRotation = false;
            pb_blur_screen.EnableShadow = true;
            pb_blur_screen.EnableSlideshow = false;
            pb_blur_screen.FlipHorizontal = false;
            pb_blur_screen.FlipVertical = false;
            pb_blur_screen.Grayscale = false;
            pb_blur_screen.Image = (Image)resources.GetObject("pb_blur_screen.Image");
            pb_blur_screen.ImageOpacity = 1F;
            pb_blur_screen.Images = (List<Image>)resources.GetObject("pb_blur_screen.Images");
            pb_blur_screen.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_blur_screen.IsCircular = false;
            pb_blur_screen.Location = new Point(1087, 0);
            pb_blur_screen.MaintainAspectRatio = true;
            pb_blur_screen.Name = "pb_blur_screen";
            pb_blur_screen.PlaceholderImage = null;
            pb_blur_screen.RotationAngle = 0F;
            pb_blur_screen.Saturation = 1F;
            pb_blur_screen.ShowBorder = true;
            pb_blur_screen.Size = new Size(248, 716);
            pb_blur_screen.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            pb_blur_screen.TabIndex = 28;
            pb_blur_screen.Text = "siticonePictureBox1";
            pb_blur_screen.Click += pb_blur_screen_Click;
            // 
            // btn_menu
            // 
            btn_menu.BackColor = Color.Transparent;
            btn_menu.BadgeBackColor = Color.Red;
            btn_menu.BadgeForeColor = Color.White;
            btn_menu.BadgeRadius = 8;
            btn_menu.BadgeRightMargin = 10;
            btn_menu.BadgeValue = 0;
            btn_menu.BorderColor = Color.FromArgb(224, 224, 224);
            btn_menu.BorderColorEnd = Color.Gray;
            btn_menu.BorderColorStart = Color.White;
            btn_menu.BorderRadiusBottomLeft = 35;
            btn_menu.BorderRadiusBottomRight = 35;
            btn_menu.BorderRadiusTopLeft = 35;
            btn_menu.BorderRadiusTopRight = 35;
            btn_menu.BorderThickness = 1;
            btn_menu.ButtonColorEnd = Color.White;
            btn_menu.ButtonColorStart = Color.White;
            btn_menu.ButtonImage = null;
            btn_menu.CanBeep = false;
            btn_menu.CanShake = false;
            btn_menu.ClickSoundPath = null;
            btn_menu.DisabledOverlayOpacity = 0.5F;
            btn_menu.EnableBorderGradient = false;
            btn_menu.EnableClickSound = false;
            btn_menu.EnableFocusBorder = false;
            btn_menu.EnableHoverSound = false;
            btn_menu.EnablePressScale = false;
            btn_menu.EnableTextShadow = false;
            btn_menu.FocusBorderColor = Color.FromArgb(100, 150, 255);
            btn_menu.FocusBorderThickness = 2;
            btn_menu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_menu.ForeColor = Color.DimGray;
            btn_menu.HoverColor = Color.FromArgb(20, 0, 0, 0);
            btn_menu.HoverSoundPath = null;
            btn_menu.HoverTransitionSpeed = 0.08F;
            btn_menu.ImageAlign = ContentAlignment.MiddleLeft;
            btn_menu.ImageLeftMargin = 5;
            btn_menu.ImageRightMargin = 8;
            btn_menu.ImageSize = 24;
            btn_menu.IsReadOnly = false;
            btn_menu.Location = new Point(55, 37);
            btn_menu.MakeRadial = false;
            btn_menu.Name = "btn_menu";
            btn_menu.PressAnimationSpeed = 0.2F;
            btn_menu.PressDepth = 1;
            btn_menu.RippleColor = Color.FromArgb(180, 180, 180);
            btn_menu.RippleExpandSpeedFactor = 0.05F;
            btn_menu.RippleFadeSpeedFactor = 0.03F;
            btn_menu.ShadowBlurFactor = 0.5F;
            btn_menu.ShadowColor = Color.FromArgb(70, 0, 0, 0);
            btn_menu.ShadowOffsetX = 2;
            btn_menu.ShadowOffsetY = 2;
            btn_menu.Size = new Size(112, 34);
            btn_menu.TabIndex = 24;
            btn_menu.Text = "Menu";
            btn_menu.TextAlign = ContentAlignment.MiddleCenter;
            btn_menu.TextPaddingBottom = 0;
            btn_menu.TextPaddingLeft = 0;
            btn_menu.TextPaddingRight = 0;
            btn_menu.TextPaddingTop = 0;
            btn_menu.TextShadowColor = Color.FromArgb(100, 0, 0, 0);
            btn_menu.TextShadowOffsetX = 1;
            btn_menu.TextShadowOffsetY = 1;
            btn_menu.Click += btn_menu_Click;
            // 
            // pb_nissan_mf
            // 
            pb_nissan_mf.BackColor = Color.White;
            pb_nissan_mf.BorderColor = Color.Black;
            pb_nissan_mf.BorderWidth = 1;
            pb_nissan_mf.Brightness = 1F;
            pb_nissan_mf.Contrast = 1F;
            pb_nissan_mf.CornerRadius = 0;
            pb_nissan_mf.DraggingSpeed = 3.15F;
            pb_nissan_mf.EnableAsyncLoading = false;
            pb_nissan_mf.EnableCaching = false;
            pb_nissan_mf.EnableDragDrop = false;
            pb_nissan_mf.EnableExtendedImageSources = false;
            pb_nissan_mf.EnableFilters = false;
            pb_nissan_mf.EnableFlipping = false;
            pb_nissan_mf.EnableGlow = false;
            pb_nissan_mf.EnableHighDpiSupport = false;
            pb_nissan_mf.EnableMouseInteraction = false;
            pb_nissan_mf.EnablePlaceholder = false;
            pb_nissan_mf.EnableRotation = false;
            pb_nissan_mf.EnableShadow = false;
            pb_nissan_mf.EnableSlideshow = false;
            pb_nissan_mf.FlipHorizontal = false;
            pb_nissan_mf.FlipVertical = false;
            pb_nissan_mf.Grayscale = false;
            pb_nissan_mf.Image = (Image)resources.GetObject("pb_nissan_mf.Image");
            pb_nissan_mf.ImageOpacity = 1F;
            pb_nissan_mf.Images = (List<Image>)resources.GetObject("pb_nissan_mf.Images");
            pb_nissan_mf.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_nissan_mf.IsCircular = false;
            pb_nissan_mf.Location = new Point(690, 1496);
            pb_nissan_mf.MaintainAspectRatio = true;
            pb_nissan_mf.Name = "pb_nissan_mf";
            pb_nissan_mf.PlaceholderImage = null;
            pb_nissan_mf.RotationAngle = 0F;
            pb_nissan_mf.Saturation = 1F;
            pb_nissan_mf.ShowBorder = true;
            pb_nissan_mf.Size = new Size(545, 466);
            pb_nissan_mf.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            pb_nissan_mf.TabIndex = 17;
            pb_nissan_mf.Text = "siticonePictureBox4";
            pb_nissan_mf.MouseEnter += pb_mf_MouseEnter;
            pb_nissan_mf.MouseLeave += pb_mf_MouseLeave;
            // 
            // pb_lambo_mf
            // 
            pb_lambo_mf.BackColor = Color.White;
            pb_lambo_mf.BorderColor = Color.Black;
            pb_lambo_mf.BorderWidth = 1;
            pb_lambo_mf.Brightness = 1F;
            pb_lambo_mf.Contrast = 1F;
            pb_lambo_mf.CornerRadius = 0;
            pb_lambo_mf.DraggingSpeed = 3.15F;
            pb_lambo_mf.EnableAsyncLoading = false;
            pb_lambo_mf.EnableCaching = false;
            pb_lambo_mf.EnableDragDrop = false;
            pb_lambo_mf.EnableExtendedImageSources = false;
            pb_lambo_mf.EnableFilters = false;
            pb_lambo_mf.EnableFlipping = false;
            pb_lambo_mf.EnableGlow = false;
            pb_lambo_mf.EnableHighDpiSupport = false;
            pb_lambo_mf.EnableMouseInteraction = false;
            pb_lambo_mf.EnablePlaceholder = false;
            pb_lambo_mf.EnableRotation = false;
            pb_lambo_mf.EnableShadow = false;
            pb_lambo_mf.EnableSlideshow = false;
            pb_lambo_mf.FlipHorizontal = false;
            pb_lambo_mf.FlipVertical = false;
            pb_lambo_mf.Grayscale = false;
            pb_lambo_mf.Image = (Image)resources.GetObject("pb_lambo_mf.Image");
            pb_lambo_mf.ImageOpacity = 1F;
            pb_lambo_mf.Images = (List<Image>)resources.GetObject("pb_lambo_mf.Images");
            pb_lambo_mf.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_lambo_mf.IsCircular = false;
            pb_lambo_mf.Location = new Point(100, 1496);
            pb_lambo_mf.MaintainAspectRatio = true;
            pb_lambo_mf.Name = "pb_lambo_mf";
            pb_lambo_mf.PlaceholderImage = null;
            pb_lambo_mf.RotationAngle = 0F;
            pb_lambo_mf.Saturation = 1F;
            pb_lambo_mf.ShowBorder = true;
            pb_lambo_mf.Size = new Size(545, 466);
            pb_lambo_mf.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            pb_lambo_mf.TabIndex = 16;
            pb_lambo_mf.Text = "siticonePictureBox3";
            pb_lambo_mf.MouseEnter += pb_mf_MouseEnter;
            pb_lambo_mf.MouseLeave += pb_mf_MouseLeave;
            // 
            // pb_porsche_logo
            // 
            pb_porsche_logo.BackColor = Color.Transparent;
            pb_porsche_logo.BorderColor = Color.Black;
            pb_porsche_logo.BorderWidth = 1;
            pb_porsche_logo.Brightness = 1F;
            pb_porsche_logo.Contrast = 1F;
            pb_porsche_logo.CornerRadius = 0;
            pb_porsche_logo.DraggingSpeed = 3.15F;
            pb_porsche_logo.EnableAsyncLoading = false;
            pb_porsche_logo.EnableCaching = false;
            pb_porsche_logo.EnableDragDrop = false;
            pb_porsche_logo.EnableExtendedImageSources = false;
            pb_porsche_logo.EnableFilters = false;
            pb_porsche_logo.EnableFlipping = false;
            pb_porsche_logo.EnableGlow = false;
            pb_porsche_logo.EnableHighDpiSupport = false;
            pb_porsche_logo.EnableMouseInteraction = false;
            pb_porsche_logo.EnablePlaceholder = false;
            pb_porsche_logo.EnableRotation = false;
            pb_porsche_logo.EnableShadow = false;
            pb_porsche_logo.EnableSlideshow = false;
            pb_porsche_logo.FlipHorizontal = false;
            pb_porsche_logo.FlipVertical = false;
            pb_porsche_logo.Grayscale = false;
            pb_porsche_logo.Image = (Image)resources.GetObject("pb_porsche_logo.Image");
            pb_porsche_logo.ImageOpacity = 1F;
            pb_porsche_logo.Images = (List<Image>)resources.GetObject("pb_porsche_logo.Images");
            pb_porsche_logo.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            pb_porsche_logo.IsCircular = false;
            pb_porsche_logo.Location = new Point(100, 960);
            pb_porsche_logo.MaintainAspectRatio = true;
            pb_porsche_logo.Name = "pb_porsche_logo";
            pb_porsche_logo.PlaceholderImage = null;
            pb_porsche_logo.RotationAngle = 0F;
            pb_porsche_logo.Saturation = 1F;
            pb_porsche_logo.ShowBorder = true;
            pb_porsche_logo.Size = new Size(195, 234);
            pb_porsche_logo.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.Normal;
            pb_porsche_logo.TabIndex = 20;
            pb_porsche_logo.Text = "siticonePictureBox1";
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
            pb_Acc.Location = new Point(1297, 37);
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
            pb_wallpaper.Location = new Point(0, 0);
            pb_wallpaper.MaintainAspectRatio = true;
            pb_wallpaper.Name = "pb_wallpaper";
            pb_wallpaper.PlaceholderImage = null;
            pb_wallpaper.RotationAngle = 0F;
            pb_wallpaper.Saturation = 1F;
            pb_wallpaper.ShowBorder = false;
            pb_wallpaper.Size = new Size(1335, 716);
            pb_wallpaper.SizeMode = SiticoneNetCoreUI.Helpers.Enum.SiticonePictureBoxSizeMode.CenterImage;
            pb_wallpaper.TabIndex = 3;
            pb_wallpaper.Text = "siticonePictureBox1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(pnl_main);
            Name = "MainForm";
            Text = "MainForm";
            pnl_main.ResumeLayout(false);
            container_menu.Panel1.ResumeLayout(false);
            container_menu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)container_menu).EndInit();
            container_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SiticoneNetCoreUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private SiticoneNetCoreUI.SiticoneContentPanel pnl_main;
        private SiticoneNetCoreUI.SiticonePictureBox pb_Acc;
        private SiticoneNetCoreUI.SiticonePictureBox pb_wallpaper;
        private SiticoneNetCoreUI.SiticonePictureBox pb_nissan_mf;
        private SiticoneNetCoreUI.SiticonePictureBox pb_lambo_mf;
        private SiticoneNetCoreUI.SiticonePictureBox pb_MacLaren_mf;
        private SiticoneNetCoreUI.SiticonePictureBox pb_porsche_mf;
        private SiticoneNetCoreUI.SiticonePictureBox pb_porsche_logo;
        private SiticoneNetCoreUI.SiticoneButtonAdvanced btn_menu;
        private SiticoneNetCoreUI.SiticoneSplitContainer container_menu;
        private SiticoneNetCoreUI.SiticonePictureBox pb_blur_screen;
        private SiticoneNetCoreUI.SiticoneButton btn_close_menu;
        private SiticoneNetCoreUI.SiticoneDashboardButton btn_menu_manufacturer_list;
        private SiticoneNetCoreUI.SiticoneDashboardButton btn_menu_services_list;
        private SiticoneNetCoreUI.SiticoneDashboardButton btn_menu_purchases_list;
        private SiticoneNetCoreUI.SiticoneDashboardButton btn_menu_acc;
        private SiticoneNetCoreUI.SiticoneShimmerLabel lbl_msg;
    }
}

