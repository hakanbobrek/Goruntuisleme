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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void GRIYAP_Click(object sender, EventArgs e)
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            Bitmap CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int GriDeger = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    double R = OkunanRenk.R;
                    double G = OkunanRenk.G;
                    double B = OkunanRenk.B;
                    GriDeger = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    DonusenRenk = Color.FromArgb(GriDeger, GriDeger, GriDeger);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;

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
    }
}
