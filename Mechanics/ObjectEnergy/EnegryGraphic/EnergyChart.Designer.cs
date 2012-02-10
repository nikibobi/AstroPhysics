namespace AstroPhysics.ObjectEnergy
{
    partial class EnergyChart
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
            this.chartEnergy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEnergy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEnergy.ChartAreas.Add(chartArea1);
            this.chartEnergy.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartEnergy.Legends.Add(legend1);
            this.chartEnergy.Location = new System.Drawing.Point(0, 0);
            this.chartEnergy.Name = "chartEnergy";
            this.chartEnergy.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartEnergy.Size = new System.Drawing.Size(498, 314);
            this.chartEnergy.TabIndex = 0;
            // 
            // EnergyChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 314);
            this.Controls.Add(this.chartEnergy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EnergyChart";
            this.Text = "EnergyChart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EnergyChart_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chartEnergy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEnergy;
    }
}