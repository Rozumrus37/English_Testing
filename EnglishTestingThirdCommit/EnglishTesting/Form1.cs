using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EnglishTesting
{
    public partial class Form1 : Form
    {
       
        
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point coordinates1 = customPictureBox1.Location;
            Point coordinates2 = customPictureBox2.Location;
            Point coordinates3 = customPictureBox3.Location;
            progressBar1.Value = 0;
            if (coordinates1.Y >= 72 && coordinates1.Y < 228 && coordinates1.X <= 209) progressBar1.Value += 35;
            if (coordinates2.Y >= 72 && coordinates2.Y < 228 && coordinates2.X <= 496 && coordinates2.X >= 287) progressBar1.Value += 35;
            if (coordinates3.Y >= 72 && coordinates3.Y < 228 && coordinates3.X <= 742 && coordinates3.X >= 540) progressBar1.Value += 30;

            if (progressBar1.Value == 100 && numericUpDown1.Value == 1)
            {
                MessageBox.Show("Congratulations");
                numericUpDown1.Value = 2;
                customPictureBox1.Location = new Point(352, 263);
                customPictureBox2.Location = new Point(631, 263);
                customPictureBox3.Location = new Point(40, 263);

                customPictureBox1.Image = customPictureBox4.Image;
                customPictureBox2.Image = customPictureBox5.Image;
                customPictureBox3.Image = customPictureBox6.Image;
                progressBar1.Value = 0;

                label1.Text = "Google Plus";
                label2.Text = "Sign OK";
                label3.Text = "YouTube";

                //Kirill Keizer Svidersky will kill me due this Indian code(If you here me, I didn't have any ways)

            } else if(progressBar1.Value == 100 && numericUpDown1.Value == 2)
            {
                MessageBox.Show("You have passed all game!!!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
