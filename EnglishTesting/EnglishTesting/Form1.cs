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
        Point coordinates;
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
            customPictureBox1.Image = Image.FromFile(images[5]);



            coordinates = customPictureBox1.Location;
            
        }
    }
}
