namespace Binance_Chart
{
    partial class frmMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimumSize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCoin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbCoin = new System.Windows.Forms.ListBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBNB = new System.Windows.Forms.Button();
            this.btnBTC = new System.Windows.Forms.Button();
            this.btnUSDT = new System.Windows.Forms.Button();
            this.btnETH = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnMinimumSize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 31);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(204)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Binance Chart";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMinimumSize
            // 
            this.btnMinimumSize.FlatAppearance.BorderSize = 0;
            this.btnMinimumSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimumSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnMinimumSize.Location = new System.Drawing.Point(1160, 0);
            this.btnMinimumSize.Name = "btnMinimumSize";
            this.btnMinimumSize.Size = new System.Drawing.Size(26, 25);
            this.btnMinimumSize.TabIndex = 0;
            this.btnMinimumSize.Text = "_";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnClose.Location = new System.Drawing.Point(1184, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCoin
            // 
            this.lblCoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCoin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCoin.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.lblCoin.Location = new System.Drawing.Point(228, 33);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(991, 42);
            this.lblCoin.TabIndex = 1;
            this.lblCoin.Text = "Binance Chart";
            this.lblCoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 808);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lbCoin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 775);
            this.panel6.TabIndex = 3;
            // 
            // lbCoin
            // 
            this.lbCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lbCoin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCoin.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoin.ForeColor = System.Drawing.Color.White;
            this.lbCoin.FormattingEnabled = true;
            this.lbCoin.ItemHeight = 17;
            this.lbCoin.Location = new System.Drawing.Point(0, 0);
            this.lbCoin.Name = "lbCoin";
            this.lbCoin.Size = new System.Drawing.Size(224, 773);
            this.lbCoin.Sorted = true;
            this.lbCoin.TabIndex = 0;
            this.lbCoin.SelectedIndexChanged += new System.EventHandler(this.lbCoin_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.btnBNB);
            this.panel7.Controls.Add(this.btnBTC);
            this.panel7.Controls.Add(this.btnUSDT);
            this.panel7.Controls.Add(this.btnETH);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 31);
            this.panel7.TabIndex = 2;
            // 
            // btnBNB
            // 
            this.btnBNB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBNB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.btnBNB.Location = new System.Drawing.Point(115, 3);
            this.btnBNB.Name = "btnBNB";
            this.btnBNB.Size = new System.Drawing.Size(50, 23);
            this.btnBNB.TabIndex = 0;
            this.btnBNB.Text = "BNB";
            this.btnBNB.UseVisualStyleBackColor = true;
            this.btnBNB.Click += new System.EventHandler(this.btnBNB_Click);
            // 
            // btnBTC
            // 
            this.btnBTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.btnBTC.Location = new System.Drawing.Point(3, 3);
            this.btnBTC.Name = "btnBTC";
            this.btnBTC.Size = new System.Drawing.Size(50, 23);
            this.btnBTC.TabIndex = 0;
            this.btnBTC.Text = "BTC";
            this.btnBTC.UseVisualStyleBackColor = true;
            this.btnBTC.Click += new System.EventHandler(this.btnBTC_Click);
            // 
            // btnUSDT
            // 
            this.btnUSDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.btnUSDT.Location = new System.Drawing.Point(171, 3);
            this.btnUSDT.Name = "btnUSDT";
            this.btnUSDT.Size = new System.Drawing.Size(50, 23);
            this.btnUSDT.TabIndex = 0;
            this.btnUSDT.Text = "USDT";
            this.btnUSDT.Click += new System.EventHandler(this.btnUSDT_Click);
            // 
            // btnETH
            // 
            this.btnETH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnETH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.btnETH.Location = new System.Drawing.Point(59, 3);
            this.btnETH.Name = "btnETH";
            this.btnETH.Size = new System.Drawing.Size(50, 23);
            this.btnETH.TabIndex = 0;
            this.btnETH.Text = "ETH";
            this.btnETH.UseVisualStyleBackColor = true;
            this.btnETH.Click += new System.EventHandler(this.btnETH_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.chartMain);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(228, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(991, 766);
            this.panel5.TabIndex = 4;
            // 
            // chartMain
            // 
            this.chartMain.BackColor = System.Drawing.Color.Transparent;
            this.chartMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartMain.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomLeft;
            chartArea6.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea6.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX.LabelStyle.Format = "MM-dd HH\"h\"";
            chartArea6.AxisX.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.LineWidth = 2;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX2.IsLabelAutoFit = false;
            chartArea6.AxisX2.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            chartArea6.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea6.AxisX2.LineWidth = 2;
            chartArea6.AxisX2.MajorGrid.Enabled = false;
            chartArea6.AxisX2.MajorTickMark.Enabled = false;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY.LineWidth = 2;
            chartArea6.AxisY.MajorGrid.Enabled = false;
            chartArea6.AxisY.MajorTickMark.Enabled = false;
            chartArea6.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea6.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea6.AxisY2.IsLabelAutoFit = false;
            chartArea6.AxisY2.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            chartArea6.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea6.AxisY2.LabelStyle.Format = "0.00000000";
            chartArea6.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea6.AxisY2.LineWidth = 2;
            chartArea6.AxisY2.MajorGrid.Enabled = false;
            chartArea6.AxisY2.MajorTickMark.Enabled = false;
            chartArea6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            chartArea6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea6);
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend6.ForeColor = System.Drawing.Color.White;
            legend6.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend6.Name = "Legend1";
            this.chartMain.Legends.Add(legend6);
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            series11.Legend = "Legend1";
            series11.Name = "Volume";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(213)))), ((int)(((byte)(109)))));
            series12.Legend = "Legend1";
            series12.Name = "Close Price";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartMain.Series.Add(series11);
            this.chartMain.Series.Add(series12);
            this.chartMain.Size = new System.Drawing.Size(989, 764);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "Binance Chart";
            this.chartMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartMain_MouseDown);
            this.chartMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartMain_MouseMove);
            this.chartMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chartMain_MouseUp);
            this.chartMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chartMain_MouseWheel);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1219, 841);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblCoin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Binance Chart";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUSDT;
        private System.Windows.Forms.Button btnBNB;
        private System.Windows.Forms.Button btnETH;
        private System.Windows.Forms.Button btnBTC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button btnMinimumSize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lbCoin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

