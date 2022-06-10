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
    public partial class Form12 : Form
    {
        public Form12()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CROSS_Click(object sender, EventArgs e)
        {
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int x, y;
            Color Renk;
            int P1, P2, P3, P4;
            for (x = 0; x < ResimGenisligi - 1; x++) 
            {
                for (y = 0; y < ResimYuksekligi - 1; y++)
                {
                    Renk = GirisResmi.GetPixel(x, y);
                    P1 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y);
                    P2 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x, y + 1);
                    P3 = (Renk.R + Renk.G + Renk.B) / 3;
                    Renk = GirisResmi.GetPixel(x + 1, y + 1);
                    P4 = (Renk.R + Renk.G + Renk.B) / 3;
                    int Gx = Math.Abs(P1 - P4); 
                    int Gy = Math.Abs(P2 - P3); 
                    int RobertCrossDegeri = 0;
                    RobertCrossDegeri = Gx;
                    RobertCrossDegeri = Gy;
                    RobertCrossDegeri = Gx + Gy; 
                    if (RobertCrossDegeri > 255) RobertCrossDegeri = 255;
                    CikisResmi.SetPixel(x, y, Color.FromArgb(RobertCrossDegeri, RobertCrossDegeri, RobertCrossDegeri));
                }
            }
            pictureBox2.Image = CikisResmi;
        }
    }
}
