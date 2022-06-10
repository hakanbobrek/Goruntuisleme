using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace gorüntüproje
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void GARYSKALA_Click(object sender, EventArgs e)
        {
            GrayscaleBT709 GR = new GrayscaleBT709();
            pictureBox2.Image = GR.Apply((Bitmap)pictureBox1.Image);
               
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SEPİA_Click(object sender, EventArgs e)
        {
             Sepia sp = new Sepia();
            pictureBox2.Image = sp.Apply((Bitmap)pictureBox1.Image);
        }
   
        private void HUE_Click(object sender, EventArgs e)
        {
                  HueModifier hu = new HueModifier();
            pictureBox2.Image = hu.Apply((Bitmap)pictureBox1.Image);
        }

        private void mavi_Click(object sender, EventArgs e)
        {
               RotateChannels rc = new RotateChannels();
            pictureBox2.Image = rc.Apply((Bitmap)pictureBox1.Image);
        }
    }
}
