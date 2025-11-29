namespace Chhipa_Motors.GUI.Admin_Panel
{
    partial class UserControl_SalesRecord
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
            dgv_sales = new DataGridView();
            radioButton_30 = new SiticoneNetCoreUI.SiticoneRadioButton();
            radioButton_7 = new SiticoneNetCoreUI.SiticoneRadioButton();
            radioButton_Today = new SiticoneNetCoreUI.SiticoneRadioButton();
            lbl_sales_record = new SiticoneNetCoreUI.SiticoneShimmerLabel();
            radioButton_All = new SiticoneNetCoreUI.SiticoneRadioButton();
            ((System.ComponentModel.ISupportInitialize)dgv_sales).BeginInit();
            SuspendLayout();
            // 
            // dgv_sales
            // 
            dgv_sales.BackgroundColor = Color.DarkSlateBlue;
            dgv_sales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sales.GridColor = Color.FromArgb(0, 0, 64);
            dgv_sales.Location = new Point(18, 126);
            dgv_sales.Name = "dgv_sales";
            dgv_sales.RowHeadersWidth = 50;
            dgv_sales.Size = new Size(910, 589);
            dgv_sales.TabIndex = 9;
            // 
            // radioButton_30
            // 
            radioButton_30.AccessibleName = "Customers";
            radioButton_30.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_30.BackColor = Color.Transparent;
            radioButton_30.CanBeep = true;
            radioButton_30.CanShake = true;
            radioButton_30.Checked = false;
            radioButton_30.CheckedColor = Color.White;
            radioButton_30.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_30.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_30.ContainerBorderWidth = 1;
            radioButton_30.ContainerBottomLeftRadius = 8;
            radioButton_30.ContainerBottomRightRadius = 8;
            radioButton_30.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_30.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_30.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_30.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_30.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_30.ContainerPadding = 8;
            radioButton_30.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_30.ContainerTopLeftRadius = 8;
            radioButton_30.ContainerTopRightRadius = 8;
            radioButton_30.ContextMenu = null;
            radioButton_30.EnableRipple = true;
            radioButton_30.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_30.HoverCursor = Cursors.Hand;
            radioButton_30.IsContained = false;
            radioButton_30.IsReadOnly = false;
            radioButton_30.Location = new Point(943, 239);
            radioButton_30.MinimumSize = new Size(178, 32);
            radioButton_30.Name = "radioButton_30";
            radioButton_30.RippleColor = Color.LightGray;
            radioButton_30.RippleDuration = 0.5F;
            radioButton_30.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_30.ShakeDuration = 0.5F;
            radioButton_30.Size = new Size(196, 40);
            radioButton_30.TabIndex = 12;
            radioButton_30.Text = "Last 30 Days";
            radioButton_30.TextColor = Color.White;
            radioButton_30.ToolTipText = "";
            radioButton_30.UncheckedColor = Color.White;
            radioButton_30.CheckedChanged += radioButton_30_CheckedChanged;
            // 
            // radioButton_7
            // 
            radioButton_7.AccessibleName = "Users";
            radioButton_7.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_7.BackColor = Color.Transparent;
            radioButton_7.CanBeep = true;
            radioButton_7.CanShake = true;
            radioButton_7.Checked = false;
            radioButton_7.CheckedColor = Color.White;
            radioButton_7.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_7.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_7.ContainerBorderWidth = 1;
            radioButton_7.ContainerBottomLeftRadius = 8;
            radioButton_7.ContainerBottomRightRadius = 8;
            radioButton_7.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_7.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_7.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_7.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_7.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_7.ContainerPadding = 8;
            radioButton_7.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_7.ContainerTopLeftRadius = 8;
            radioButton_7.ContainerTopRightRadius = 8;
            radioButton_7.ContextMenu = null;
            radioButton_7.EnableRipple = true;
            radioButton_7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_7.HoverCursor = Cursors.Hand;
            radioButton_7.IsContained = false;
            radioButton_7.IsReadOnly = false;
            radioButton_7.Location = new Point(943, 179);
            radioButton_7.MinimumSize = new Size(178, 32);
            radioButton_7.Name = "radioButton_7";
            radioButton_7.RippleColor = Color.LightGray;
            radioButton_7.RippleDuration = 0.5F;
            radioButton_7.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_7.ShakeDuration = 0.5F;
            radioButton_7.Size = new Size(196, 40);
            radioButton_7.TabIndex = 11;
            radioButton_7.Text = "Last 7 Days";
            radioButton_7.TextColor = Color.White;
            radioButton_7.ToolTipText = "";
            radioButton_7.UncheckedColor = Color.White;
            radioButton_7.CheckedChanged += radioButton_7_CheckedChanged;
            // 
            // radioButton_Today
            // 
            radioButton_Today.AccessibleName = "Admins";
            radioButton_Today.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_Today.BackColor = Color.Transparent;
            radioButton_Today.CanBeep = true;
            radioButton_Today.CanShake = true;
            radioButton_Today.Checked = false;
            radioButton_Today.CheckedColor = Color.White;
            radioButton_Today.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_Today.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_Today.ContainerBorderWidth = 1;
            radioButton_Today.ContainerBottomLeftRadius = 8;
            radioButton_Today.ContainerBottomRightRadius = 8;
            radioButton_Today.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_Today.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_Today.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_Today.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_Today.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_Today.ContainerPadding = 8;
            radioButton_Today.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_Today.ContainerTopLeftRadius = 8;
            radioButton_Today.ContainerTopRightRadius = 8;
            radioButton_Today.ContextMenu = null;
            radioButton_Today.EnableRipple = true;
            radioButton_Today.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_Today.HoverCursor = Cursors.Hand;
            radioButton_Today.IsContained = false;
            radioButton_Today.IsReadOnly = false;
            radioButton_Today.Location = new Point(943, 124);
            radioButton_Today.MinimumSize = new Size(178, 32);
            radioButton_Today.Name = "radioButton_Today";
            radioButton_Today.RippleColor = Color.LightGray;
            radioButton_Today.RippleDuration = 0.5F;
            radioButton_Today.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_Today.ShakeDuration = 0.5F;
            radioButton_Today.Size = new Size(196, 40);
            radioButton_Today.TabIndex = 10;
            radioButton_Today.Text = "Today";
            radioButton_Today.TextColor = Color.White;
            radioButton_Today.ToolTipText = "";
            radioButton_Today.UncheckedColor = Color.White;
            radioButton_Today.CheckedChanged += radioButton_Today_CheckedChanged;
            // 
            // lbl_sales_record
            // 
            lbl_sales_record.AutoReverse = false;
            lbl_sales_record.BaseColor = Color.White;
            lbl_sales_record.Direction = SiticoneNetCoreUI.ShimmerDirection.LeftToRight;
            lbl_sales_record.Font = new Font("Modern No. 20", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sales_record.IsAnimating = true;
            lbl_sales_record.IsPaused = false;
            lbl_sales_record.Location = new Point(342, 26);
            lbl_sales_record.Name = "lbl_sales_record";
            lbl_sales_record.PauseDuration = 0;
            lbl_sales_record.ShimmerColor = Color.DarkSlateBlue;
            lbl_sales_record.ShimmerOpacity = 1F;
            lbl_sales_record.ShimmerSpeed = 50;
            lbl_sales_record.ShimmerWidth = 0.2F;
            lbl_sales_record.Size = new Size(340, 50);
            lbl_sales_record.TabIndex = 13;
            lbl_sales_record.Text = "Sales Record";
            lbl_sales_record.ToolTipText = "";
            // 
            // radioButton_All
            // 
            radioButton_All.AccessibleName = "";
            radioButton_All.AccessibleRole = AccessibleRole.RadioButton;
            radioButton_All.BackColor = Color.Transparent;
            radioButton_All.CanBeep = true;
            radioButton_All.CanShake = true;
            radioButton_All.Checked = true;
            radioButton_All.CheckedColor = Color.White;
            radioButton_All.ContainerBackColor = Color.FromArgb(20, 0, 0, 0);
            radioButton_All.ContainerBorderColor = Color.FromArgb(50, 0, 0, 0);
            radioButton_All.ContainerBorderWidth = 1;
            radioButton_All.ContainerBottomLeftRadius = 8;
            radioButton_All.ContainerBottomRightRadius = 8;
            radioButton_All.ContainerCheckedBorderColor = Color.FromArgb(50, 56, 128, 255);
            radioButton_All.ContainerCheckedColor = Color.FromArgb(20, 56, 128, 255);
            radioButton_All.ContainerCheckedHoverColor = Color.FromArgb(25, 56, 128, 255);
            radioButton_All.ContainerCheckedPressedColor = Color.FromArgb(30, 56, 128, 255);
            radioButton_All.ContainerHoverColor = Color.FromArgb(25, 0, 0, 0);
            radioButton_All.ContainerPadding = 8;
            radioButton_All.ContainerPressedColor = Color.FromArgb(30, 0, 0, 0);
            radioButton_All.ContainerTopLeftRadius = 8;
            radioButton_All.ContainerTopRightRadius = 8;
            radioButton_All.ContextMenu = null;
            radioButton_All.EnableRipple = true;
            radioButton_All.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_All.HoverCursor = Cursors.Hand;
            radioButton_All.IsContained = false;
            radioButton_All.IsReadOnly = false;
            radioButton_All.Location = new Point(943, 298);
            radioButton_All.MinimumSize = new Size(178, 32);
            radioButton_All.Name = "radioButton_All";
            radioButton_All.RippleColor = Color.LightGray;
            radioButton_All.RippleDuration = 0.5F;
            radioButton_All.RippleStyle = SiticoneNetCoreUI.SiticoneRadioButton.RippleAnimationStyle.Smooth;
            radioButton_All.ShakeDuration = 0.5F;
            radioButton_All.Size = new Size(196, 40);
            radioButton_All.TabIndex = 14;
            radioButton_All.Text = "All";
            radioButton_All.TextColor = Color.White;
            radioButton_All.ToolTipText = "";
            radioButton_All.UncheckedColor = Color.White;
            radioButton_All.CheckedChanged += radioButton_All_CheckedChanged;
            // 
            // UserControl_SalesRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            Controls.Add(radioButton_All);
            Controls.Add(lbl_sales_record);
            Controls.Add(radioButton_30);
            Controls.Add(radioButton_7);
            Controls.Add(radioButton_Today);
            Controls.Add(dgv_sales);
            Name = "UserControl_SalesRecord";
            Size = new Size(1220, 771);
            ((System.ComponentModel.ISupportInitialize)dgv_sales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_sales;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_30;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_7;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_Today;
        private SiticoneNetCoreUI.SiticoneShimmerLabel lbl_sales_record;
        private SiticoneNetCoreUI.SiticoneRadioButton radioButton_All;
    }
}
