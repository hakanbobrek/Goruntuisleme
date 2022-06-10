using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace gorüntüproje
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
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

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
         //   this.Opacity = (double)trackBar1.Value / 100;
        }

        private void BTN_PRLK_Click(object sender, EventArgs e)
        {

            int R = 0, G = 0, B = 0; Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; 
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); 
            int i = 0, j = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                j = 0;
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y); 
                    R = OkunanRenk.R + trackBar1.Value;
                    G = OkunanRenk.G + trackBar1.Value; 
                    B = OkunanRenk.B + trackBar1.Value;
                    if (R > 255) R = 255; if (G > 255) 
                        G = 255;
                    if (B > 255) 
                        B = 255;
                    DonusenRenk = Color.FromArgb(R, G, B); 
                    CikisResmi.SetPixel(i, j, DonusenRenk);
                    j++;
                }
                i++;
            }
            pictureBox2.Image = CikisResmi;
        }
    }
}
