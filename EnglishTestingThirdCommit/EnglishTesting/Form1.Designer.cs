namespace EnglishTesting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.customPictureBox6 = new EnglishTesting.CustomPictureBox(this.components);
            this.customPictureBox5 = new EnglishTesting.CustomPictureBox(this.components);
            this.customPictureBox4 = new EnglishTesting.CustomPictureBox(this.components);
            this.customPictureBox3 = new EnglishTesting.CustomPictureBox(this.components);
            this.customPictureBox2 = new EnglishTesting.CustomPictureBox(this.components);
            this.customPictureBox1 = new EnglishTesting.CustomPictureBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Facebook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Twiter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(678, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Instagram";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 334);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(745, 30);
            this.progressBar1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 33);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(352, 405);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // customPictureBox6
            // 
            this.customPictureBox6.Image = global::EnglishTesting.Properties.Resources._41;
            this.customPictureBox6.Location = new System.Drawing.Point(274, 278);
            this.customPictureBox6.Name = "customPictureBox6";
            this.customPictureBox6.Size = new System.Drawing.Size(50, 35);
            this.customPictureBox6.TabIndex = 16;
            this.customPictureBox6.TabStop = false;
            this.customPictureBox6.Visible = false;
            // 
            // customPictureBox5
            // 
            this.customPictureBox5.Image = global::EnglishTesting.Properties.Resources._6;
            this.customPictureBox5.Location = new System.Drawing.Point(203, 278);
            this.customPictureBox5.Name = "customPictureBox5";
            this.customPictureBox5.Size = new System.Drawing.Size(53, 35);
            this.customPictureBox5.TabIndex = 15;
            this.customPictureBox5.TabStop = false;
            this.customPictureBox5.Visible = false;
            // 
            // customPictureBox4
            // 
            this.customPictureBox4.Image = global::EnglishTesting.Properties.Resources._3;
            this.customPictureBox4.Location = new System.Drawing.Point(146, 278);
            this.customPictureBox4.Name = "customPictureBox4";
            this.customPictureBox4.Size = new System.Drawing.Size(51, 35);
            this.customPictureBox4.TabIndex = 14;
            this.customPictureBox4.TabStop = false;
            this.customPictureBox4.Visible = false;
            // 
            // customPictureBox3
            // 
            this.customPictureBox3.Image = global::EnglishTesting.Properties.Resources._5;
            this.customPictureBox3.Location = new System.Drawing.Point(40, 263);
            this.customPictureBox3.Name = "customPictureBox3";
            this.customPictureBox3.Size = new System.Drawing.Size(100, 50);
            this.customPictureBox3.TabIndex = 2;
            this.customPictureBox3.TabStop = false;
            // 
            // customPictureBox2
            // 
            this.customPictureBox2.Image = global::EnglishTesting.Properties.Resources._2;
            this.customPictureBox2.Location = new System.Drawing.Point(631, 263);
            this.customPictureBox2.Name = "customPictureBox2";
            this.customPictureBox2.Size = new System.Drawing.Size(100, 50);
            this.customPictureBox2.TabIndex = 1;
            this.customPictureBox2.TabStop = false;
            // 
            // customPictureBox1
            // 
            this.customPictureBox1.Image = global::EnglishTesting.Properties.Resources._1;
            this.customPictureBox1.Location = new System.Drawing.Point(352, 263);
            this.customPictureBox1.Name = "customPictureBox1";
            this.customPictureBox1.Size = new System.Drawing.Size(100, 50);
            this.customPictureBox1.TabIndex = 0;
            this.customPictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customPictureBox6);
            this.Controls.Add(this.customPictureBox5);
            this.Controls.Add(this.customPictureBox4);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customPictureBox3);
            this.Controls.Add(this.customPictureBox2);
            this.Controls.Add(this.customPictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomPictureBox customPictureBox1;
        private CustomPictureBox customPictureBox2;
        private CustomPictureBox customPictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private CustomPictureBox customPictureBox4;
        private CustomPictureBox customPictureBox5;
        private CustomPictureBox customPictureBox6;
    }
}

