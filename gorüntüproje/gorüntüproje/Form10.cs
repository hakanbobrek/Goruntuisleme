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
    public partial class Form10 : Form
    {
        public Form10()
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

        private void SOBEL_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmiX, CikisResmiY, CikisResmiXY;
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmiX = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            CikisResmiXY = new Bitmap(ResimGenisligi, ResimYuksekligi);
            int SablonBoyutu = 3;
            int ElemanSayisi = SablonBoyutu * SablonBoyutu;
            int x, y, i, j;
            int Gri = 0;
            int[] MatrisX = { -1, 0, 1, -2, 0, 2, -1, 0, 1 };
            int[] MatrisY = { 1, 2, 1, 0, 0, 0, -1, -2, -1 };
            int RenkX, RenkY, RenkXY;
            for (x = (SablonBoyutu - 1) / 2; x < ResimGenisligi - (SablonBoyutu - 1) / 2; x++) 
            {
                for (y = (SablonBoyutu - 1) / 2; y < ResimYuksekligi - (SablonBoyutu - 1) / 2; y++)
                {
                    int toplamGriX = 0, toplamGriY = 0;
                    int k = 0; 
                    for (i = -((SablonBoyutu - 1) / 2); i <= (SablonBoyutu - 1) / 2; i++)
                    {
                        for (j = -((SablonBoyutu - 1) / 2); j <= (SablonBoyutu - 1) / 2; j++)
                        {
                            OkunanRenk = GirisResmi.GetPixel(x + i, y + j);
                            Gri = (OkunanRenk.R + OkunanRenk.G + OkunanRenk.B) / 3;
                            toplamGriX = toplamGriX + Gri * MatrisX[k];
                            toplamGriY = toplamGriY + Gri * MatrisY[k];
                            k++;
                        }
                    }
                    RenkX = Math.Abs(toplamGriX);
                    RenkY = Math.Abs(toplamGriY);
                    RenkXY = Math.Abs(toplamGriX) + Math.Abs(toplamGriY);
                    //Renkler sınırların dışına çıktıysa, sınır değer alınacak.
                    if (RenkX > 255) RenkX = 255;
                    if (RenkY > 255) RenkY = 255;
                    if (RenkXY > 255) RenkXY = 255;
                    if (RenkX < 0) RenkX = 0;
                    if (RenkY < 0) RenkY = 0;
                    if (RenkXY < 0) RenkXY = 0;
                    CikisResmiX.SetPixel(x, y, Color.FromArgb(RenkX, RenkX, RenkX));
                    CikisResmiY.SetPixel(x, y, Color.FromArgb(RenkY, RenkY, RenkY));
                    CikisResmiXY.SetPixel(x, y, Color.FromArgb(RenkXY, RenkXY, RenkXY));
                }
            }
            pictureBox2.Image = CikisResmiY;
            pictureBox3.Image = CikisResmiX;
            pictureBox4.Image = CikisResmiXY;
        }
    }
}
