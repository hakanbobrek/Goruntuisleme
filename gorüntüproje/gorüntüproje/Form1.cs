using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Imaging;

namespace gorüntüproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
       
        private void GRIYAP_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void negatıfalma_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_PRL_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
            this.Hide();
        }

        private void BTN_ESK_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void BTN_HST_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            this.Hide();
        }

        private void btnknt_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void ORTFLT_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();
        }

        private void MDNFLT_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void sobel_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void PrewittAlgoritması_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
            this.Hide();
        }

        private void RobertCross_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();
        }

        private void tasıma_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Hide();
        }

        private void aynalama_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.Show();
            this.Hide();
        }

        private void egmekaydırma_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.Show();
            this.Hide();
        }

        private void zoom_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
        }

        private void dondurma_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            frm17.Show();
            this.Hide();
        }

        private void Konvolüsyonyöntemi_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            frm18.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form19 frm19 = new Form19();
            frm19.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form20 frm20 = new Form20();
            frm20.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form21 frm21 = new Form21();
            frm21.Show();
            this.Hide();
        }
    }
}
