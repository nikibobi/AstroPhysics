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
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDownMass = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKineticEnergy = new System.Windows.Forms.TextBox();
            this.textBoxPotentialEnergy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEnergyChart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMechanicEnergy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).BeginInit();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(120, 233);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(138, 31);
            this.numericUpDownSpeed.TabIndex = 3;
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Скорост";
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numericUpDownMass
            // 
            this.numericUpDownMass.Location = new System.Drawing.Point(120, 185);
            this.numericUpDownMass.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMass.Name = "numericUpDownMass";
            this.numericUpDownMass.Size = new System.Drawing.Size(138, 31);
            this.numericUpDownMass.TabIndex = 7;
            this.numericUpDownMass.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMass.ValueChanged += new System.EventHandler(this.numericUpDownMass_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Маса";
            // 
            // textBoxKineticEnergy
            // 
            this.textBoxKineticEnergy.Location = new System.Drawing.Point(255, 286);
            this.textBoxKineticEnergy.Name = "textBoxKineticEnergy";
            this.textBoxKineticEnergy.ReadOnly = true;
            this.textBoxKineticEnergy.Size = new System.Drawing.Size(249, 31);
            this.textBoxKineticEnergy.TabIndex = 9;
            // 
            // textBoxPotentialEnergy
            // 
            this.textBoxPotentialEnergy.Location = new System.Drawing.Point(255, 323);
            this.textBoxPotentialEnergy.Name = "textBoxPotentialEnergy";
            this.textBoxPotentialEnergy.ReadOnly = true;
            this.textBoxPotentialEnergy.Size = new System.Drawing.Size(249, 31);
            this.textBoxPotentialEnergy.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Кинетична енергия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Потенциална енергия";
            // 
            // buttonEnergyChart
            // 
            this.buttonEnergyChart.Enabled = false;
            this.buttonEnergyChart.Location = new System.Drawing.Point(24, 391);
            this.buttonEnergyChart.Name = "buttonEnergyChart";
            this.buttonEnergyChart.Size = new System.Drawing.Size(149, 49);
            this.buttonEnergyChart.TabIndex = 15;
            this.buttonEnergyChart.Text = "Graph";
            this.buttonEnergyChart.UseVisualStyleBackColor = true;
            this.buttonEnergyChart.Visible = false;
            this.buttonEnergyChart.Click += new System.EventHandler(this.buttonEnergyChart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Механична енергия";
            // 
            // textBoxMechanicEnergy
            // 
            this.textBoxMechanicEnergy.Location = new System.Drawing.Point(255, 360);
            this.textBoxMechanicEnergy.Name = "textBoxMechanicEnergy";
            this.textBoxMechanicEnergy.ReadOnly = true;
            this.textBoxMechanicEnergy.Size = new System.Drawing.Size(249, 31);
            this.textBoxMechanicEnergy.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "m/s";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.numericUpDownVolume);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.comboBox1);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.textBoxKineticEnergy);
            this.groupBox.Controls.Add(this.buttonEnergyChart);
            this.groupBox.Controls.Add(this.numericUpDownSpeed);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.textBoxMechanicEnergy);
            this.groupBox.Controls.Add(this.textBoxPotentialEnergy);
            this.groupBox.Controls.Add(this.numericUpDownMass);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox.Location = new System.Drawing.Point(150, 47);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(594, 472);
            this.groupBox.TabIndex = 19;
            this.groupBox.TabStop = false;
            this.groupBox.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Материал";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(288, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Обем";
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Location = new System.Drawing.Point(120, 142);
            this.numericUpDownVolume.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(138, 31);
            this.numericUpDownVolume.TabIndex = 20;
            this.numericUpDownVolume.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDownVolume.ValueChanged += new System.EventHandler(this.numericUpDownVolume_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "m";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Злато",
            "Желязо",
            "Мед",
            "Сребро",
            "Олово"});
            this.comboBox1.Location = new System.Drawing.Point(137, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // MechanicEnergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AstroPhysics.Properties.Resources.MechanicEnergy_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 688);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonApply);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MechanicEnergy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Механична енергия";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MechanicEnergy_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MechanicEnergy_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMass)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numericUpDownMass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKineticEnergy;
        private System.Windows.Forms.TextBox textBoxPotentialEnergy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMechanicEnergy;
        private System.Windows.Forms.Button buttonEnergyChart;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonApply;
    }
}