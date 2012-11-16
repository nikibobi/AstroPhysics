namespace AstroPhysics.ObjectEnergy
{
    partial class MechanicEnergy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MechanicEnergy));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.backButton1 = new AstroPhysics.Controls.BackButton();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply.Location = new System.Drawing.Point(12, 643);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(138, 42);
            this.buttonApply.TabIndex = 20;
            this.buttonApply.Text = "Свойства";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraph.Location = new System.Drawing.Point(156, 643);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(138, 42);
            this.buttonGraph.TabIndex = 21;
            this.buttonGraph.Text = "Графика";
            this.buttonGraph.UseVisualStyleBackColor = true;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // backButton1
            // 
            this.backButton1.BackColor = System.Drawing.Color.Transparent;
            this.backButton1.BackgroundImage = global::AstroPhysics.Properties.Resources.door_out;
            this.backButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.backButton1.Location = new System.Drawing.Point(862, 12);
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(20, 20);
            this.backButton1.TabIndex = 22;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // MechanicEnergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AstroPhysics.Properties.Resources.MechanicEnergy_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 688);
            this.Controls.Add(this.backButton1);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonApply);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MechanicEnergy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AstroPhysics - Механична енергия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MechanicEnergy_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MechanicEnergy_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonGraph;
        private Controls.BackButton backButton1;
    }
}