namespace MyPacketCapture
{
    partial class frmStatistics
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chEtherTypes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chProtocols = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtETypes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProtocols = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMac = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chEtherTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProtocols)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chEtherTypes
            // 
            this.chEtherTypes.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BackColor = System.Drawing.Color.Transparent;
            chartArea11.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea11.Name = "ChartArea1";
            this.chEtherTypes.ChartAreas.Add(chartArea11);
            legend11.BackColor = System.Drawing.Color.Transparent;
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.chEtherTypes.Legends.Add(legend11);
            this.chEtherTypes.Location = new System.Drawing.Point(12, 12);
            this.chEtherTypes.Name = "chEtherTypes";
            this.chEtherTypes.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series11.Legend = "Legend1";
            series11.Name = "s1";
            this.chEtherTypes.Series.Add(series11);
            this.chEtherTypes.Size = new System.Drawing.Size(300, 300);
            this.chEtherTypes.TabIndex = 0;
            this.chEtherTypes.Text = "EtherTypes";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chProtocols
            // 
            this.chProtocols.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackColor = System.Drawing.Color.Transparent;
            chartArea12.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chProtocols.ChartAreas.Add(chartArea12);
            legend12.BackColor = System.Drawing.Color.Transparent;
            legend12.Enabled = false;
            legend12.Name = "Legend1";
            this.chProtocols.Legends.Add(legend12);
            this.chProtocols.Location = new System.Drawing.Point(322, 12);
            this.chProtocols.Name = "chProtocols";
            this.chProtocols.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "s1";
            this.chProtocols.Series.Add(series12);
            this.chProtocols.Size = new System.Drawing.Size(300, 300);
            this.chProtocols.TabIndex = 1;
            this.chProtocols.Text = "Protocols";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtETypes);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EtherTypes";
            // 
            // txtETypes
            // 
            this.txtETypes.BackColor = System.Drawing.Color.White;
            this.txtETypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtETypes.Location = new System.Drawing.Point(6, 19);
            this.txtETypes.Multiline = true;
            this.txtETypes.Name = "txtETypes";
            this.txtETypes.ReadOnly = true;
            this.txtETypes.Size = new System.Drawing.Size(288, 109);
            this.txtETypes.TabIndex = 0;
            this.txtETypes.TextChanged += new System.EventHandler(this.txtETypes_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProtocols);
            this.groupBox2.Location = new System.Drawing.Point(12, 465);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 134);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Protocols";
            // 
            // txtProtocols
            // 
            this.txtProtocols.BackColor = System.Drawing.Color.White;
            this.txtProtocols.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProtocols.Location = new System.Drawing.Point(6, 19);
            this.txtProtocols.Multiline = true;
            this.txtProtocols.Name = "txtProtocols";
            this.txtProtocols.ReadOnly = true;
            this.txtProtocols.Size = new System.Drawing.Size(288, 109);
            this.txtProtocols.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMac);
            this.groupBox3.Location = new System.Drawing.Point(322, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 281);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MAC Addresses";
            // 
            // txtMac
            // 
            this.txtMac.BackColor = System.Drawing.Color.White;
            this.txtMac.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMac.Location = new System.Drawing.Point(6, 19);
            this.txtMac.Multiline = true;
            this.txtMac.Name = "txtMac";
            this.txtMac.ReadOnly = true;
            this.txtMac.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMac.Size = new System.Drawing.Size(288, 256);
            this.txtMac.TabIndex = 0;
            // 
            // frmStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chProtocols);
            this.Controls.Add(this.chEtherTypes);
            this.Name = "frmStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chEtherTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chProtocols)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chEtherTypes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chProtocols;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtETypes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtProtocols;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMac;
    }
}