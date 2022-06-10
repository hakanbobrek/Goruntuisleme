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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

       private void KONTRAS_Click(object sender, EventArgs e)
        {
            int R = 0, G = 0, B = 0;
            Color OkunanRenk, DonusenRenk;
            Bitmap GirisResmi, CikisResmi;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width; 
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); 
            double C_KontrastSeviyesi = Convert.ToInt32(trackBar1.Value);
            double F_KontrastFaktoru = (259 * (C_KontrastSeviyesi + 255)) / (255 * (259 - C_KontrastSeviyesi));
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    R = (int)((F_KontrastFaktoru * (R - 128)) + 128);
                    G = (int)((F_KontrastFaktoru * (G - 128)) + 128);
                    B = (int)((F_KontrastFaktoru * (B - 128)) + 128);
                    if (R > 255) R = 255;
                    if (G > 255) G = 255;
                    if (B > 255) B = 255;
                    if (R < 0) R = 0;
                    if (G < 0) G = 0;
                    if (B < 0) B = 0;
                    DonusenRenk = Color.FromArgb(R, G, B);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            pictureBox2.Image = CikisResmi;
        }
       
       
        private void Form7_Load(object sender, EventArgs e)
        {
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.DefaultExt = ".jpg"; openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String ResminYolu = openFileDialog1.FileName; pictureBox1.Image = Image.FromFile(ResminYolu);
            }
            catch { }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
