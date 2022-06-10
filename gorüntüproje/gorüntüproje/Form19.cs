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
    public partial class Form19 : Form
    {
        public Form19()
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
        private void GENISLETME_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            Bitmap OrjinalResim, GenislemisResim;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            Bitmap SiyahBeyazResim = ResmiGriTonaDonusturEsiklemeYap(GirisResmi);
            pictureBox2.Image = SiyahBeyazResim;
            GirisResmi = SiyahBeyazResim;
            int x, y, i, j;
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) 
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    bool RenkSiyah = false;
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            if (OkunanRenk.R < 128) 
                                RenkSiyah = true;
                        }
                    }
                    if (RenkSiyah == true) 
                    {
                        Color KendiRengi = GirisResmi.GetPixel(x, y);
                        if (KendiRengi.R > 128) 
                            CikisResmi.SetPixel(x, y, Color.FromArgb(255, 0, 0)); 
                    }
                    else 
                        CikisResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            pictureBox3.Image = CikisResmi;
            SiyahBeyazResim = new Bitmap(pictureBox2.Image);
            GenislemisResim = new Bitmap(pictureBox3.Image);
            Bitmap KenarGoruntuResmi = OrjinalResimdenGenislemisResmiCikar(SiyahBeyazResim, GenislemisResim);
            pictureBox4.Image = KenarGoruntuResmi;
        }
        
        public Bitmap OrjinalResimdenGenislemisResmiCikar(Bitmap SiyahBeyazResim, Bitmap GenislemisResim)
        {
            Bitmap CikisResmi;
            int ResimGenisligi = SiyahBeyazResim.Width;
            int ResimYuksekligi = SiyahBeyazResim.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int x, y;
            int Fark;
            for (x = 0; x < ResimGenisligi; x++) 
            {
                for (y = 0; y < ResimYuksekligi; y++)
                {
                    Color OrjinalRenk = SiyahBeyazResim.GetPixel(x, y);
                    Color GenislemisResimRenk = GenislemisResim.GetPixel(x, y);
                    int OrjinalGri = (OrjinalRenk.R + OrjinalRenk.G + OrjinalRenk.B) / 3;
                    int GenislemisGri = (GenislemisResimRenk.R + GenislemisResimRenk.G + GenislemisResimRenk.B) / 3;
                    Fark = Math.Abs(OrjinalGri - GenislemisGri);
                    CikisResmi.SetPixel(x, y, Color.FromArgb(Fark, Fark, Fark));
                }
            }
            return CikisResmi;
        }

       private void MORFO_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi;
            Bitmap SiyahBeyazResim = new Bitmap(pictureBox2.Image);
            int ResimGenisligi = SiyahBeyazResim.Width;
            int ResimYuksekligi = SiyahBeyazResim.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            GirisResmi = SiyahBeyazResim;
            int x, y, i, j;
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int Esikleme = 0;
            try
            {
                Esikleme = Convert.ToInt16(textBox1.Text);
            }
            catch
            {
                Esikleme=128;
            }
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) 
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    if (OkunanRenk.R > Esikleme) 
                    {
                        bool KomsulardaSiyahVarMi = false;
                        for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                        {
                            for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                            {
                                OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                                if (OkunanRenk.R < Esikleme)
                                    KomsulardaSiyahVarMi = true;
                            }
                        }
                        if (KomsulardaSiyahVarMi == true) 
                        {
                            Color KendiRengi = GirisResmi.GetPixel(x, y);
                            CikisResmi.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                        else 
                            CikisResmi.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    }
                }
            }
            pictureBox4.Image = CikisResmi;
        }
        public Bitmap ResmiGriTonaDonusturEsiklemeYap(Bitmap GirisResmi)
        {
            Color OkunanRenk, DonusenRenk;
            Bitmap CikisResmi;
            int ResimGenisligi = GirisResmi.Width; 
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi); 
            int i = 0, j = 0;
            int R = 0, G = 0, B = 0;
            for (int x = 0; x < ResimGenisligi; x++)
            {
                for (int y = 0; y < ResimYuksekligi; y++)
                {
                    OkunanRenk = GirisResmi.GetPixel(x, y);
                    R = OkunanRenk.R;
                    G = OkunanRenk.G;
                    B = OkunanRenk.B;
                    int Gri = Convert.ToInt16(R * 0.3 + G * 0.6 + B * 0.1);
                    int Esikleme = 0;
                    try
                    {
                        Esikleme = Convert.ToInt16(textBox1.Text);
                    }
                    catch
                    {
                        Esikleme = 128;
                    }
                    if (Gri > Esikleme)
                        Gri = 255;
                    else
                        Gri = 0;
                    DonusenRenk = Color.FromArgb(Gri, Gri, Gri);
                    CikisResmi.SetPixel(x, y, DonusenRenk);
                }
            }
            return CikisResmi;
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
