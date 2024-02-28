namespace Para_06._09
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.LResolution = new System.Windows.Forms.Label();
            this.LDensity = new System.Windows.Forms.Label();
            this.NUDResolution = new System.Windows.Forms.NumericUpDown();
            this.NUDDensity = new System.Windows.Forms.NumericUpDown();
            this.BStop = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BAgain = new System.Windows.Forms.Button();
            this.BStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NUDResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LResolution
            // 
            this.LResolution.AutoSize = true;
            this.LResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LResolution.Location = new System.Drawing.Point(12, 18);
            this.LResolution.Name = "LResolution";
            this.LResolution.Size = new System.Drawing.Size(81, 16);
            this.LResolution.TabIndex = 0;
            this.LResolution.Text = "Resolution";
            // 
            // LDensity
            // 
            this.LDensity.AutoSize = true;
            this.LDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LDensity.Location = new System.Drawing.Point(12, 66);
            this.LDensity.Name = "LDensity";
            this.LDensity.Size = new System.Drawing.Size(59, 16);
            this.LDensity.TabIndex = 1;
            this.LDensity.Text = "Density";
            // 
            // NUDResolution
            // 
            this.NUDResolution.Location = new System.Drawing.Point(15, 37);
            this.NUDResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NUDResolution.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDResolution.Name = "NUDResolution";
            this.NUDResolution.Size = new System.Drawing.Size(120, 20);
            this.NUDResolution.TabIndex = 3;
            this.NUDResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDResolution.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NUDDensity
            // 
            this.NUDDensity.Location = new System.Drawing.Point(15, 85);
            this.NUDDensity.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NUDDensity.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUDDensity.Name = "NUDDensity";
            this.NUDDensity.Size = new System.Drawing.Size(120, 20);
            this.NUDDensity.TabIndex = 4;
            this.NUDDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BStop
            // 
            this.BStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStop.Location = new System.Drawing.Point(25, 165);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(90, 52);
            this.BStop.TabIndex = 6;
            this.BStop.Text = "Stop";
            this.BStop.UseVisualStyleBackColor = true;
            this.BStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.BAgain);
            this.splitContainer1.Panel1.Controls.Add(this.BStop);
            this.splitContainer1.Panel1.Controls.Add(this.NUDDensity);
            this.splitContainer1.Panel1.Controls.Add(this.BStart);
            this.splitContainer1.Panel1.Controls.Add(this.NUDResolution);
            this.splitContainer1.Panel1.Controls.Add(this.LResolution);
            this.splitContainer1.Panel1.Controls.Add(this.LDensity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Цвет клеток";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Crismos",
            "Green",
            "Blue",
            "Pink",
            "White"});
            this.comboBox1.Location = new System.Drawing.Point(10, 384);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // BAgain
            // 
            this.BAgain.Location = new System.Drawing.Point(28, 233);
            this.BAgain.Name = "BAgain";
            this.BAgain.Size = new System.Drawing.Size(90, 23);
            this.BAgain.TabIndex = 7;
            this.BAgain.Text = "Again";
            this.BAgain.UseVisualStyleBackColor = true;
            this.BAgain.Click += new System.EventHandler(this.BContinue_Click);
            // 
            // BStart
            // 
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(25, 125);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(90, 34);
            this.BStart.TabIndex = 2;
            this.BStart.Text = "Start";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(646, 446);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Игра жизнь";
            ((System.ComponentModel.ISupportInitialize)(this.NUDResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDDensity)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LResolution;
        private System.Windows.Forms.Label LDensity;
        private System.Windows.Forms.NumericUpDown NUDResolution;
        private System.Windows.Forms.NumericUpDown NUDDensity;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BAgain;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

