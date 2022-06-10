using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
       private void BTN_HSTGRM_Click(object sender, EventArgs e)
        {
            ArrayList DiziPiksel = new ArrayList();
            int OrtalamaRenk = 0; 
            Color OkunanRenk;
            int R = 0, G = 0, B = 0;
            Bitmap GirisResmi;
            GirisResmi = new Bitmap(pictureBox2.Image);
            int ResimGenisligi = GirisResmi.Width; 
            int ResimYuksekligi = GirisResmi.Height;
            int i = 0; 
            for (int x = 0; x < GirisResmi.Width; x++)
            {
                for (int y = 0; y < GirisResmi.Height; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y); 
                    OrtalamaRenk = (int)(OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3; 
                    DiziPiksel.Add(OrtalamaRenk); 
                }
            }
            int[] DiziPikselSayilari = new int[256];
            for (int r = 0; r <= 255; r++)
            {
                int PikselSayisi = 0; for (int s = 0; s < DiziPiksel.Count; s++) 
                {
                    if (r == Convert.ToInt16(DiziPiksel[s])) PikselSayisi++;
                }
                DiziPikselSayilari[r] = PikselSayisi;
            }
            
            int RenkMaksPikselSayisi = 0; 
            for (int k = 0; k <= 255; k++)
            {
                listBox1.Items.Add("Renk:" + k + "=" + DiziPikselSayilari[k]); 
                if (DiziPikselSayilari[k] > RenkMaksPikselSayisi)
                {
                    RenkMaksPikselSayisi = DiziPikselSayilari[k];
                }
            }
            Graphics CizimAlani;
            Pen Kalem1 = new Pen(System.Drawing.Color.Yellow, 1);
            Pen Kalem2 = new Pen(System.Drawing.Color.Red, 1);
            CizimAlani = pictureBox3.CreateGraphics();
            pictureBox3.Refresh();
            int GrafikYuksekligi = 300;
            double OlcekY = RenkMaksPikselSayisi / GrafikYuksekligi; double OlcekX = 1.5;
            int X_kaydirma = 10;
            for (int x = 0; x <= 255; x++)
            {
                if (x % 50 == 0)
                    CizimAlani.DrawLine(Kalem2, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), 0);
                CizimAlani.DrawLine(Kalem1, (int)(X_kaydirma + x * OlcekX), GrafikYuksekligi, (int)(X_kaydirma + x * OlcekX), (GrafikYuksekligi - (int)(DiziPikselSayilari[x] / OlcekY)));
                
            }
            textBox1.Text = "Maks.Piks=" + RenkMaksPikselSayisi.ToString();
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

        private void button3_Click(object sender, EventArgs e)
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

     
    }
}
