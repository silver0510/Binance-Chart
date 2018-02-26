﻿namespace Binance_Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimumSize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lvCoin = new System.Windows.Forms.ListView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBNB = new System.Windows.Forms.Button();
            this.btnBTC = new System.Windows.Forms.Button();
            this.btnUSDT = new System.Windows.Forms.Button();
            this.btnETH = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.btnMinimumSize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 33);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimumSize
            // 
            this.btnMinimumSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimumSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnMinimumSize.Location = new System.Drawing.Point(1152, 3);
            this.btnMinimumSize.Name = "btnMinimumSize";
            this.btnMinimumSize.Size = new System.Drawing.Size(26, 26);
            this.btnMinimumSize.TabIndex = 0;
            this.btnMinimumSize.Text = "_";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnClose.Location = new System.Drawing.Point(1184, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(196)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(228, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(991, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Binance Chart";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel6.Controls.Add(this.lvCoin);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 31);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 775);
            this.panel6.TabIndex = 3;
            // 
            // lvCoin
            // 
            this.lvCoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lvCoin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCoin.ForeColor = System.Drawing.Color.White;
            this.lvCoin.Location = new System.Drawing.Point(0, 0);
            this.lvCoin.MultiSelect = false;
            this.lvCoin.Name = "lvCoin";
            this.lvCoin.Size = new System.Drawing.Size(224, 773);
            this.lvCoin.TabIndex = 0;
            this.lvCoin.UseCompatibleStateImageBehavior = false;
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
            this.btnBNB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnBNB.Location = new System.Drawing.Point(115, 3);
            this.btnBNB.Name = "btnBNB";
            this.btnBNB.Size = new System.Drawing.Size(50, 23);
            this.btnBNB.TabIndex = 0;
            this.btnBNB.Text = "BNB";
            this.btnBNB.UseVisualStyleBackColor = true;
            // 
            // btnBTC
            // 
            this.btnBTC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
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
            this.btnUSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnUSDT.Location = new System.Drawing.Point(171, 3);
            this.btnUSDT.Name = "btnUSDT";
            this.btnUSDT.Size = new System.Drawing.Size(50, 23);
            this.btnUSDT.TabIndex = 0;
            this.btnUSDT.Text = "USDT";
            // 
            // btnETH
            // 
            this.btnETH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnETH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnETH.Location = new System.Drawing.Point(59, 3);
            this.btnETH.Name = "btnETH";
            this.btnETH.Size = new System.Drawing.Size(50, 23);
            this.btnETH.TabIndex = 0;
            this.btnETH.Text = "ETH";
            this.btnETH.UseVisualStyleBackColor = true;
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
            chartArea4.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea4.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX.LabelStyle.Format = "yy-MM-dd HH:mm";
            chartArea4.AxisX.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.LineWidth = 2;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisX2.IsLabelAutoFit = false;
            chartArea4.AxisX2.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            chartArea4.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea4.AxisX2.LineWidth = 2;
            chartArea4.AxisX2.MajorGrid.Enabled = false;
            chartArea4.AxisX2.MajorTickMark.Enabled = false;
            chartArea4.AxisY.IsLabelAutoFit = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY.LineWidth = 2;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea4.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea4.AxisY2.IsLabelAutoFit = false;
            chartArea4.AxisY2.LabelStyle.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            chartArea4.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea4.AxisY2.LineWidth = 2;
            chartArea4.AxisY2.MajorGrid.Enabled = false;
            chartArea4.AxisY2.MajorTickMark.Enabled = false;
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
            chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea4);
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.BackColor = System.Drawing.Color.Transparent;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend4.ForeColor = System.Drawing.Color.White;
            legend4.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend4.Name = "Legend1";
            this.chartMain.Legends.Add(legend4);
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            series7.Legend = "Legend1";
            series7.Name = "Volume";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(213)))), ((int)(((byte)(109)))));
            series8.Legend = "Legend1";
            series8.Name = "Close Price";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chartMain.Series.Add(series7);
            this.chartMain.Series.Add(series8);
            this.chartMain.Size = new System.Drawing.Size(989, 764);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "Binance Chart";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1219, 841);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
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
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUSDT;
        private System.Windows.Forms.Button btnBNB;
        private System.Windows.Forms.Button btnETH;
        private System.Windows.Forms.Button btnBTC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.ListView lvCoin;
        private System.Windows.Forms.Button btnMinimumSize;
        private System.Windows.Forms.Button btnClose;
    }
}
