/******************************************************************************
 *
 * Filename: PicoVNA21LogMagDesigner.cs
 * 
 * Copyright (C) 2018 Pico Technology Ltd. See LICENSE file for terms.
 *
 ******************************************************************************/

namespace PicoVNAS21LogMagGuiExample
{
    partial class PicoVNAS21LogMag
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.normalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.frequencyTextBox = new System.Windows.Forms.TextBox();
            this.getDataButton = new System.Windows.Forms.Button();
            this.calButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.normalChart)).BeginInit();
            this.SuspendLayout();
            // 
            // normalChart
            // 
            chartArea1.AxisX.Title = "Frequency";
            chartArea1.AxisY.Title = "Data";
            chartArea1.Name = "ChartArea1";
            this.normalChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.normalChart.Legends.Add(legend1);
            this.normalChart.Location = new System.Drawing.Point(-1, 156);
            this.normalChart.Name = "normalChart";
            this.normalChart.Size = new System.Drawing.Size(503, 179);
            this.normalChart.TabIndex = 173;
            this.normalChart.Text = "chart1";
            this.normalChart.Visible = false;
            // 
            // frequencyTextBox
            // 
            this.frequencyTextBox.Location = new System.Drawing.Point(259, 8);
            this.frequencyTextBox.Multiline = true;
            this.frequencyTextBox.Name = "frequencyTextBox";
            this.frequencyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.frequencyTextBox.Size = new System.Drawing.Size(333, 142);
            this.frequencyTextBox.TabIndex = 172;
            this.frequencyTextBox.Visible = false;
            // 
            // getDataButton
            // 
            this.getDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getDataButton.Location = new System.Drawing.Point(134, 75);
            this.getDataButton.Name = "getDataButton";
            this.getDataButton.Size = new System.Drawing.Size(119, 52);
            this.getDataButton.TabIndex = 171;
            this.getDataButton.Text = "Get Data";
            this.getDataButton.UseVisualStyleBackColor = true;
            this.getDataButton.Visible = false;
            this.getDataButton.Click += new System.EventHandler(this.getDataButton_Click);
            // 
            // calButton
            // 
            this.calButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calButton.Location = new System.Drawing.Point(9, 75);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(119, 52);
            this.calButton.TabIndex = 170;
            this.calButton.Text = "Calibrate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Visible = false;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(12, 8);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(81, 52);
            this.closeButton.TabIndex = 169;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Visible = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // openButton
            // 
            this.openButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openButton.Location = new System.Drawing.Point(9, 8);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(81, 52);
            this.openButton.TabIndex = 168;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // PicoVNAS21logmagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 346);
            this.Controls.Add(this.normalChart);
            this.Controls.Add(this.frequencyTextBox);
            this.Controls.Add(this.getDataButton);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Name = "PicoVNAS21logmagForm";
            this.Text = "PicoVNA S21 Log Mag";
            ((System.ComponentModel.ISupportInitialize)(this.normalChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart normalChart;
        private System.Windows.Forms.TextBox frequencyTextBox;
        private System.Windows.Forms.Button getDataButton;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openButton;
    }
}

