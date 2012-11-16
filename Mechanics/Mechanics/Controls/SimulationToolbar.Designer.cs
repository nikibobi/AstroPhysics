namespace AstroPhysics.Controls
{
    partial class SimulationToolbar
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
            this.play = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Image = global::AstroPhysics.Properties.Resources.play;
            this.play.Location = new System.Drawing.Point(39, 36);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(16, 16);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.play.TabIndex = 0;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // panel
            // 
            this.panel.Image = global::AstroPhysics.Properties.Resources.Calculator_BG;
            this.panel.Location = new System.Drawing.Point(6, 18);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(390, 38);
            this.panel.TabIndex = 1;
            this.panel.TabStop = false;
            this.panel.MouseEnter += new System.EventHandler(this.panel_MouseEnter);
            this.panel.MouseLeave += new System.EventHandler(this.panel_MouseLeave);
            // 
            // SimulationToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.play);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.Name = "SimulationToolbar";
            this.Size = new System.Drawing.Size(396, 55);
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox panel;
    }
}
