﻿using System;
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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void AYNA_Click(object sender, EventArgs e)
        {
            Color OkunanRenk;
            Bitmap GirisResmi, CikisResmi; 
            GirisResmi = new Bitmap(pictureBox1.Image);
            int ResimGenisligi = GirisResmi.Width;
            int ResimYuksekligi = GirisResmi.Height;
            CikisResmi = new Bitmap(ResimGenisligi, ResimYuksekligi);
            if (textBox1.Text != "")
            {
                double Aci = Convert.ToDouble(textBox1.Text);
                double RadyanAci = Aci * 2 * Math.PI / 360;
                double x2 = 0, y2 = 0;
                int x0 = ResimGenisligi / 2;
                int y0 = ResimYuksekligi / 2;
                for (int x1 = 0; x1 < (ResimGenisligi); x1++)
                {
                    for (int y1 = 0; y1 < (ResimYuksekligi); y1++)
                    {
                        OkunanRenk = GirisResmi.GetPixel(x1, y1);
                        double Delta = (x1 - x0) * Math.Sin(RadyanAci) - (y1 - y0) * Math.Cos(RadyanAci);
                        x2 = Convert.ToInt16(x1 + 2 * Delta * (-Math.Sin(RadyanAci)));
                        y2 = Convert.ToInt16(y1 + 2 * Delta * (Math.Cos(RadyanAci)));
                        if (x2 > 0 && x2 < ResimGenisligi && y2 > 0 && y2 < ResimYuksekligi)
                            CikisResmi.SetPixel((int)x2, (int)y2, OkunanRenk);
                    }
                }
                pictureBox2.Image = CikisResmi;
            }
            else
                MessageBox.Show("AÇI DEĞERİ GİR");
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

       
    }
}
