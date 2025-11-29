using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Chhipa_Motors.BL;

namespace Chhipa_Motors.GUI.Admin_Panel
{
    public partial class UserControl_SalesRecord : UserControl
    {
        private AdminBL _adminBL;

        private Panel headerPanel;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel filterPanel;
        private RadioButton radioButton_Today;
        private RadioButton radioButton_7;
        private RadioButton radioButton_30;
        private RadioButton radioButton_All;
        private DataGridView dgv_sales;
        private Panel statsPanel;
        private Label lblTotalSales;
        private Label lblTotalRevenue;
        private Label lblAverageOrder;

        public UserControl_SalesRecord()
        {
            InitializeComponent();
            _adminBL = new AdminBL();

            InitializeCustomComponents();
            LoadSalesRecord(0);
        }

        private void InitializeCustomComponents()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.Dock = DockStyle.Fill;

            // Header Panel
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
                Text = "Sales Record",
                Font = new Font("Segoe UI", 32, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 25)
            };

            // Subtitle
            lblSubtitle = new Label
            {
                Text = "Track and analyze sales performance",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(40, 84)
            };

            headerPanel.Controls.AddRange(new Control[] { lblTitle, lblSubtitle });

            // Filter Panel (Card with radio buttons)
            filterPanel = new Panel
            {
                Location = new Point(40, 150),
                Size = new Size(this.Width - 80, 80),
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            filterPanel.Paint += FilterPanel_Paint;

            Label lblFilter = new Label
            {
                Text = "Filter by:",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(30, 25),
                AutoSize = true
            };

            // Radio Buttons
            radioButton_Today = new RadioButton
            {
                Text = "📅 Today",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(180, 20),
                Size = new Size(120, 40),
                Appearance = Appearance.Button,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            radioButton_Today.FlatAppearance.BorderSize = 0;
            radioButton_Today.FlatAppearance.CheckedBackColor = Color.FromArgb(102, 126, 234);
            radioButton_Today.CheckedChanged += radioButton_Today_CheckedChanged;

            radioButton_7 = new RadioButton
            {
                Text = "📊 Last 7 Days",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(315, 20),
                Size = new Size(140, 40),
                Appearance = Appearance.Button,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            radioButton_7.FlatAppearance.BorderSize = 0;
            radioButton_7.FlatAppearance.CheckedBackColor = Color.FromArgb(102, 126, 234);
            radioButton_7.CheckedChanged += radioButton_7_CheckedChanged;

            radioButton_30 = new RadioButton
            {
                Text = "📈 Last 30 Days",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(470, 20),
                Size = new Size(150, 40),
                Appearance = Appearance.Button,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            radioButton_30.FlatAppearance.BorderSize = 0;
            radioButton_30.FlatAppearance.CheckedBackColor = Color.FromArgb(102, 126, 234);
            radioButton_30.CheckedChanged += radioButton_30_CheckedChanged;

            radioButton_All = new RadioButton
            {
                Text = "🌐 All Time",
                Font = new Font("Segoe UI", 11),
                ForeColor = Color.FromArgb(51, 51, 51),
                Location = new Point(635, 20),
                Size = new Size(120, 40),
                Appearance = Appearance.Button,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand,
                Checked = true
            };
            radioButton_All.FlatAppearance.BorderSize = 0;
            radioButton_All.FlatAppearance.CheckedBackColor = Color.FromArgb(102, 126, 234);
            radioButton_All.CheckedChanged += radioButton_All_CheckedChanged;

            // Style radio buttons
            foreach (RadioButton rb in new[] { radioButton_Today, radioButton_7, radioButton_30, radioButton_All })
            {
                rb.CheckedChanged += (s, e) =>
                {
                    if (rb.Checked)
                    {
                        rb.ForeColor = Color.White;
                        rb.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    }
                    else
                    {
                        rb.ForeColor = Color.FromArgb(51, 51, 51);
                        rb.Font = new Font("Segoe UI", 11);
                    }
                };
            }

            filterPanel.Controls.AddRange(new Control[] {
                lblFilter, radioButton_Today, radioButton_7, radioButton_30, radioButton_All
            });

            // Stats Panel
            statsPanel = new Panel
            {
                Location = new Point(40, 250),
                Size = new Size(this.Width - 80, 80),
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Stats Cards
            Panel statsCard1 = CreateStatsCard("Total Sales", "0", Color.FromArgb(102, 126, 234), 0);
            Panel statsCard2 = CreateStatsCard("Total Revenue", "$0", Color.FromArgb(76, 175, 80), 1);
            Panel statsCard3 = CreateStatsCard("Avg Order Value", "$0", Color.FromArgb(255, 152, 0), 2);

            lblTotalSales = (Label)statsCard1.Controls[1];
            lblTotalRevenue = (Label)statsCard2.Controls[1];
            lblAverageOrder = (Label)statsCard3.Controls[1];

            statsPanel.Controls.AddRange(new Control[] { statsCard1, statsCard2, statsCard3 });

            // DataGridView Container
            Panel dgvContainer = new Panel
            {
                Location = new Point(40, 350),
                Size = new Size(this.Width - 80, this.Height - 380),
                BackColor = Color.White,
                Padding = new Padding(15),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };

            // DataGridView
            dgv_sales = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeight = 45,
                RowTemplate = { Height = 40 },
                EnableHeadersVisualStyles = false,
                GridColor = Color.FromArgb(230, 230, 230),
                Font = new Font("Segoe UI", 10)
            };

            // Header style
            dgv_sales.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(102, 126, 234),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };

            // Cell style
            dgv_sales.DefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.White,
                ForeColor = Color.FromArgb(51, 51, 51),
                SelectionBackColor = Color.FromArgb(102, 126, 234),
                SelectionForeColor = Color.White,
                Padding = new Padding(10, 5, 10, 5),
                Font = new Font("Segoe UI", 10)
            };

            // Alternating rows
            dgv_sales.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(248, 249, 252),
                ForeColor = Color.FromArgb(51, 51, 51),
                SelectionBackColor = Color.FromArgb(102, 126, 234),
                SelectionForeColor = Color.White,
                Padding = new Padding(10, 5, 10, 5)
            };

            dgv_sales.DataBindingComplete += Dgv_sales_DataBindingComplete;

            dgvContainer.Controls.Add(dgv_sales);

            this.Controls.AddRange(new Control[] {
                headerPanel, filterPanel, statsPanel, dgvContainer
            });
        }

        private Panel CreateStatsCard(string title, string value, Color accentColor, int position)
        {
            int cardWidth = (this.Width - 140) / 3;
            int spacing = 30;

            Panel card = new Panel
            {
                Size = new Size(cardWidth, 80),
                Location = new Point(position * (cardWidth + spacing), 0),
                BackColor = Color.White,
                Anchor = position == 0 ? AnchorStyles.Left : (position == 2 ? AnchorStyles.Right : AnchorStyles.None)
            };
            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Shadow
                using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(15, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(shadowBrush, 3, 3, card.Width - 3, card.Height - 3);
                }

                // Card background
                using (GraphicsPath path = GetRoundedRectPath(new Rectangle(0, 0, card.Width - 1, card.Height - 1), 12))
                {
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        e.Graphics.FillPath(brush, path);
                    }

                    using (Pen pen = new Pen(Color.FromArgb(230, 230, 230), 1))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }

                // Accent bar
                using (SolidBrush accentBrush = new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(accentBrush, 0, 0, 5, card.Height);
                }
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Gray,
                Location = new Point(20, 15),
                AutoSize = true
            };

            Label lblValue = new Label
            {
                Text = value,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(20, 35),
                AutoSize = true
            };

            card.Controls.AddRange(new Control[] { lblTitle, lblValue });

            return card;
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

        private void FilterPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Shadow
            using (SolidBrush shadowBrush = new SolidBrush(Color.FromArgb(15, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(shadowBrush, 3, 3, filterPanel.Width - 3, filterPanel.Height - 3);
            }

            // Card
            using (GraphicsPath path = GetRoundedRectPath(
                new Rectangle(0, 0, filterPanel.Width - 1, filterPanel.Height - 1), 12))
            {
                using (SolidBrush brush = new SolidBrush(Color.White))
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

        private void Dgv_sales_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv_sales.Columns.Count > 0)
            {
                if (dgv_sales.Columns.Contains("SaleID"))
                {
                    dgv_sales.Columns["SaleID"].HeaderText = "Sale #";
                    dgv_sales.Columns["SaleID"].Width = 80;
                }

                if (dgv_sales.Columns.Contains("UserID"))
                {
                    dgv_sales.Columns["UserID"].HeaderText = "User ID";
                    dgv_sales.Columns["UserID"].Width = 80;
                }

                if (dgv_sales.Columns.Contains("Username"))
                {
                    dgv_sales.Columns["Username"].HeaderText = "Customer";
                    dgv_sales.Columns["Username"].Width = 130;
                }

                if (dgv_sales.Columns.Contains("CarID"))
                {
                    dgv_sales.Columns["CarID"].Visible = false;
                }

                if (dgv_sales.Columns.Contains("Manufacturer"))
                {
                    dgv_sales.Columns["Manufacturer"].HeaderText = "Manufacturer";
                    dgv_sales.Columns["Manufacturer"].Width = 130;
                }

                if (dgv_sales.Columns.Contains("CarName"))
                {
                    dgv_sales.Columns["CarName"].HeaderText = "Car Model";
                    dgv_sales.Columns["CarName"].Width = 180;
                }

                if (dgv_sales.Columns.Contains("SaleDate"))
                {
                    dgv_sales.Columns["SaleDate"].HeaderText = "Sale Date";
                    dgv_sales.Columns["SaleDate"].DefaultCellStyle.Format = "MMM dd, yyyy";
                    dgv_sales.Columns["SaleDate"].Width = 130;
                }

                if (dgv_sales.Columns.Contains("TotalAmount"))
                {
                    dgv_sales.Columns["TotalAmount"].HeaderText = "Amount";
                    dgv_sales.Columns["TotalAmount"].DefaultCellStyle.Format = "C0";
                    dgv_sales.Columns["TotalAmount"].Width = 120;
                }
            }

            // Update statistics
            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            int totalSales = dgv_sales.Rows.Count;
            decimal totalRevenue = 0;

            foreach (DataGridViewRow row in dgv_sales.Rows)
            {
                if (row.Cells["TotalAmount"].Value != null)
                {
                    totalRevenue += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                }
            }

            decimal avgOrder = totalSales > 0 ? totalRevenue / totalSales : 0;

            lblTotalSales.Text = totalSales.ToString();
            lblTotalRevenue.Text = totalRevenue.ToString("C0");
            lblAverageOrder.Text = avgOrder.ToString("C0");
        }

        public void LoadSalesRecord(int filter)
        {
            try
            {
                dgv_sales.DataSource = _adminBL.getSalesRecord(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton_Today_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Today.Checked)
            {
                LoadSalesRecord(1);
            }
        }

        private void radioButton_7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_7.Checked)
            {
                LoadSalesRecord(7);
            }
        }

        private void radioButton_30_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_30.Checked)
            {
                LoadSalesRecord(30);
            }
        }

        private void radioButton_All_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_All.Checked)
            {
                LoadSalesRecord(0);
            }
        }
    }
}