namespace AstroPhysics.Astronomy
{
    partial class SolarSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolarSystem));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x05SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x20SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x40SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x160SpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseToolStripMenuItem,
            this.x05SpeedToolStripMenuItem,
            this.playToolStripMenuItem,
            this.x20SpeedToolStripMenuItem,
            this.x40SpeedToolStripMenuItem,
            this.x160SpeedToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(157, 158);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Image = global::AstroPhysics.Properties.Resources.pause;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pauseToolStripMenuItem.Text = "Пауза";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // x05SpeedToolStripMenuItem
            // 
            this.x05SpeedToolStripMenuItem.Image = global::AstroPhysics.Properties.Resources.rewind;
            this.x05SpeedToolStripMenuItem.Name = "x05SpeedToolStripMenuItem";
            this.x05SpeedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.x05SpeedToolStripMenuItem.Text = "x0.5 скорост";
            this.x05SpeedToolStripMenuItem.Click += new System.EventHandler(this.x05SpeedToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Image = global::AstroPhysics.Properties.Resources.play;
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.playToolStripMenuItem.Text = "Пусни";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // x20SpeedToolStripMenuItem
            // 
            this.x20SpeedToolStripMenuItem.Image = global::AstroPhysics.Properties.Resources.fastforward;
            this.x20SpeedToolStripMenuItem.Name = "x20SpeedToolStripMenuItem";
            this.x20SpeedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.x20SpeedToolStripMenuItem.Text = "x2.0 скорост";
            this.x20SpeedToolStripMenuItem.Click += new System.EventHandler(this.x20SpeedToolStripMenuItem_Click);
            // 
            // x40SpeedToolStripMenuItem
            // 
            this.x40SpeedToolStripMenuItem.Image = global::AstroPhysics.Properties.Resources.fastforward;
            this.x40SpeedToolStripMenuItem.Name = "x40SpeedToolStripMenuItem";
            this.x40SpeedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.x40SpeedToolStripMenuItem.Text = "x4.0 скорост";
            this.x40SpeedToolStripMenuItem.Click += new System.EventHandler(this.x40SpeedToolStripMenuItem_Click);
            // 
            // x160SpeedToolStripMenuItem
            // 
            this.x160SpeedToolStripMenuItem.Image = global::AstroPhysics.Properties.Resources.fastforward;
            this.x160SpeedToolStripMenuItem.Name = "x160SpeedToolStripMenuItem";
            this.x160SpeedToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.x160SpeedToolStripMenuItem.Text = "x16.0 скорост";
            this.x160SpeedToolStripMenuItem.Click += new System.EventHandler(this.x160SpeedToolStripMenuItem_Click);
            // 
            // SolarSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(892, 686);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SolarSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Слънчевата система";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolarSystem_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SolarSystem_Paint);
            this.Resize += new System.EventHandler(this.SolarSystem_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x20SpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x40SpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x160SpeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x05SpeedToolStripMenuItem;
    }
}