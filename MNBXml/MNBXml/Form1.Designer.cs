﻿namespace MNBXml
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tolPicker = new System.Windows.Forms.DateTimePicker();
            this.igPicker = new System.Windows.Forms.DateTimePicker();
            this.cbValuta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea3.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartRateData.Legends.Add(legend3);
            this.chartRateData.Location = new System.Drawing.Point(344, 58);
            this.chartRateData.Name = "chartRateData";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartRateData.Series.Add(series3);
            this.chartRateData.Size = new System.Drawing.Size(492, 380);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // tolPicker
            // 
            this.tolPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tolPicker.Location = new System.Drawing.Point(12, 13);
            this.tolPicker.Name = "tolPicker";
            this.tolPicker.Size = new System.Drawing.Size(100, 20);
            this.tolPicker.TabIndex = 2;
            this.tolPicker.ValueChanged += new System.EventHandler(this.paramChanged);
            // 
            // igPicker
            // 
            this.igPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.igPicker.Location = new System.Drawing.Point(117, 12);
            this.igPicker.Name = "igPicker";
            this.igPicker.Size = new System.Drawing.Size(100, 20);
            this.igPicker.TabIndex = 3;
            this.igPicker.ValueChanged += new System.EventHandler(this.paramChanged);
            // 
            // cbValuta
            // 
            this.cbValuta.FormattingEnabled = true;
            this.cbValuta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "CHF"});
            this.cbValuta.Location = new System.Drawing.Point(224, 12);
            this.cbValuta.Name = "cbValuta";
            this.cbValuta.Size = new System.Drawing.Size(121, 21);
            this.cbValuta.TabIndex = 4;
            this.cbValuta.SelectedIndexChanged += new System.EventHandler(this.paramChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 450);
            this.Controls.Add(this.cbValuta);
            this.Controls.Add(this.igPicker);
            this.Controls.Add(this.tolPicker);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker tolPicker;
        private System.Windows.Forms.DateTimePicker igPicker;
        private System.Windows.Forms.ComboBox cbValuta;
    }
}

