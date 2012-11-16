namespace AstroPhysics.Controls
{
    partial class ScrollBar
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
            this.components = new System.ComponentModel.Container();
            this.handle = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.handle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // handle
            // 
            this.handle.Image = global::AstroPhysics.Properties.Resources.Ball;
            this.handle.Location = new System.Drawing.Point(3, 0);
            this.handle.Name = "handle";
            this.handle.Size = new System.Drawing.Size(32, 32);
            this.handle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.handle.TabIndex = 0;
            this.handle.TabStop = false;
            this.handle.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AstroPhysics.Properties.Resources.Grass;
            this.pictureBox2.Location = new System.Drawing.Point(3, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 10);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ScrollBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.handle);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ScrollBar";
            this.Size = new System.Drawing.Size(380, 34);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScrollBar_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScrollBar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScrollBar_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.handle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox handle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer;

    }
}
