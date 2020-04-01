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
       
        public string[] images = { "Photos/1.png", "Photos/2.png", "Photos/3.png", "Photos/4.png", "Photos/5.png", "Photos/6.png" };
        public Form1()
        {
            InitializeComponent();
        }

    

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   customPictureBox1.Image = Image.FromFile("Photos/1.png");
            customPictureBox1.Image = Image.FromFile
  (System.Environment.GetFolderPath
  (System.Environment.SpecialFolder.Personal)
  + @"\English_testing_windows_form\Photos\1.png");
            Point coordinates1 = customPictureBox1.Location;
         Point coordinates2 = customPictureBox2.Location;
         Point coordinates3 = customPictureBox3.Location;
         progressBar1.Value = 0;
         if (coordinates1.Y >= 72 && coordinates1.Y < 228 && coordinates1.X <= 209) progressBar1.Value += 35;
         if (coordinates2.Y >= 72 && coordinates2.Y < 228 && coordinates2.X <= 496 && coordinates2.X >= 287) progressBar1.Value += 35;
         if (coordinates3.Y >= 72 && coordinates3.Y < 228 && coordinates3.X <= 742 && coordinates3.X >= 540) progressBar1.Value += 30;

            if (progressBar1.Value == 100) MessageBox.Show("Congratulations");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
