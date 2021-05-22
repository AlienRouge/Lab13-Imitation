
namespace WindowsFormsApp2
{
    partial class Geimetric
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.NumberOfExper = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.RelAver = new System.Windows.Forms.Label();
            this.RelVariance = new System.Windows.Forms.Label();
            this.ResChi = new System.Windows.Forms.Label();
            this.Pprob = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfExper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pprob)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(209, 15);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(402, 391);
            this.chart1.TabIndex = 0;
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.BorderWidth = 10;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "Probability";
            this.chart1.Titles.Add(title4);
            // 
            // NumberOfExper
            // 
            this.NumberOfExper.Location = new System.Drawing.Point(43, 75);
            this.NumberOfExper.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumberOfExper.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.NumberOfExper.Name = "NumberOfExper";
            this.NumberOfExper.Size = new System.Drawing.Size(90, 20);
            this.NumberOfExper.TabIndex = 5;
            this.NumberOfExper.ThousandsSeparator = true;
            this.NumberOfExper.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of experiments:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(43, 105);
            this.Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(90, 38);
            this.Start.TabIndex = 13;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // RelAver
            // 
            this.RelAver.AutoSize = true;
            this.RelAver.Location = new System.Drawing.Point(40, 169);
            this.RelAver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RelAver.Name = "RelAver";
            this.RelAver.Size = new System.Drawing.Size(0, 13);
            this.RelAver.TabIndex = 16;
            // 
            // RelVariance
            // 
            this.RelVariance.AutoSize = true;
            this.RelVariance.Location = new System.Drawing.Point(40, 191);
            this.RelVariance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RelVariance.Name = "RelVariance";
            this.RelVariance.Size = new System.Drawing.Size(0, 13);
            this.RelVariance.TabIndex = 17;
            // 
            // ResChi
            // 
            this.ResChi.AutoSize = true;
            this.ResChi.Location = new System.Drawing.Point(40, 215);
            this.ResChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResChi.Name = "ResChi";
            this.ResChi.Size = new System.Drawing.Size(0, 13);
            this.ResChi.TabIndex = 18;
            // 
            // Pprob
            // 
            this.Pprob.DecimalPlaces = 2;
            this.Pprob.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Pprob.Location = new System.Drawing.Point(63, 22);
            this.Pprob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pprob.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Pprob.Name = "Pprob";
            this.Pprob.Size = new System.Drawing.Size(53, 20);
            this.Pprob.TabIndex = 19;
            this.Pprob.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "P0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.ResChi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RelVariance);
            this.panel1.Controls.Add(this.Pprob);
            this.panel1.Controls.Add(this.RelAver);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.NumberOfExper);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Location = new System.Drawing.Point(4, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 391);
            this.panel1.TabIndex = 22;
            // 
            // Geimetric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 418);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Geimetric";
            this.Text = "Geometric";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfExper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pprob)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown NumberOfExper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label RelAver;
        private System.Windows.Forms.Label RelVariance;
        private System.Windows.Forms.Label ResChi;
        private System.Windows.Forms.NumericUpDown Pprob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

