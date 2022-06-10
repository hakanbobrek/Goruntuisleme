namespace gorüntüproje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GRIYAP = new System.Windows.Forms.Button();
            this.negatıfalma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_HST = new System.Windows.Forms.Button();
            this.BTN_ESK = new System.Windows.Forms.Button();
            this.BTN_PRL = new System.Windows.Forms.Button();
            this.RobertCross = new System.Windows.Forms.Button();
            this.PrewittAlgoritması = new System.Windows.Forms.Button();
            this.sobel = new System.Windows.Forms.Button();
            this.MDNFLT = new System.Windows.Forms.Button();
            this.ORTFLT = new System.Windows.Forms.Button();
            this.btnknt = new System.Windows.Forms.Button();
            this.Konvolüsyonyöntemi = new System.Windows.Forms.Button();
            this.dondurma = new System.Windows.Forms.Button();
            this.zoom = new System.Windows.Forms.Button();
            this.egmekaydırma = new System.Windows.Forms.Button();
            this.aynalama = new System.Windows.Forms.Button();
            this.tasıma = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GRIYAP
            // 
            this.GRIYAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GRIYAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GRIYAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GRIYAP.Location = new System.Drawing.Point(27, 161);
            this.GRIYAP.Name = "GRIYAP";
            this.GRIYAP.Size = new System.Drawing.Size(173, 65);
            this.GRIYAP.TabIndex = 0;
            this.GRIYAP.Text = "GRİ YAP";
            this.GRIYAP.UseVisualStyleBackColor = false;
            this.GRIYAP.Click += new System.EventHandler(this.GRIYAP_Click);
            // 
            // negatıfalma
            // 
            this.negatıfalma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.negatıfalma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.negatıfalma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.negatıfalma.Location = new System.Drawing.Point(221, 161);
            this.negatıfalma.Name = "negatıfalma";
            this.negatıfalma.Size = new System.Drawing.Size(181, 65);
            this.negatıfalma.TabIndex = 1;
            this.negatıfalma.Text = "NEGATİF ALMA ";
            this.negatıfalma.UseVisualStyleBackColor = false;
            this.negatıfalma.Click += new System.EventHandler(this.negatıfalma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(342, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "GÖRÜNTÜ İŞLEME ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(23, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "YAPILMAK İSTENEN İŞLEMİ SEÇİNİZ:";
            // 
            // BTN_HST
            // 
            this.BTN_HST.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_HST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_HST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_HST.Location = new System.Drawing.Point(805, 163);
            this.BTN_HST.Name = "BTN_HST";
            this.BTN_HST.Size = new System.Drawing.Size(173, 63);
            this.BTN_HST.TabIndex = 20;
            this.BTN_HST.Text = "HİSTOGRAM";
            this.BTN_HST.UseVisualStyleBackColor = false;
            this.BTN_HST.Click += new System.EventHandler(this.BTN_HST_Click);
            // 
            // BTN_ESK
            // 
            this.BTN_ESK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_ESK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ESK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_ESK.Location = new System.Drawing.Point(610, 161);
            this.BTN_ESK.Name = "BTN_ESK";
            this.BTN_ESK.Size = new System.Drawing.Size(173, 63);
            this.BTN_ESK.TabIndex = 19;
            this.BTN_ESK.Text = "EŞİKLEME YAP";
            this.BTN_ESK.UseVisualStyleBackColor = false;
            this.BTN_ESK.Click += new System.EventHandler(this.BTN_ESK_Click);
            // 
            // BTN_PRL
            // 
            this.BTN_PRL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BTN_PRL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_PRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_PRL.Location = new System.Drawing.Point(418, 161);
            this.BTN_PRL.Name = "BTN_PRL";
            this.BTN_PRL.Size = new System.Drawing.Size(173, 63);
            this.BTN_PRL.TabIndex = 18;
            this.BTN_PRL.Text = "PARLAKLIK";
            this.BTN_PRL.UseVisualStyleBackColor = false;
            this.BTN_PRL.Click += new System.EventHandler(this.BTN_PRL_Click);
            // 
            // RobertCross
            // 
            this.RobertCross.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RobertCross.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RobertCross.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RobertCross.Location = new System.Drawing.Point(28, 378);
            this.RobertCross.Name = "RobertCross";
            this.RobertCross.Size = new System.Drawing.Size(172, 63);
            this.RobertCross.TabIndex = 29;
            this.RobertCross.Text = "ROBERT CROSS";
            this.RobertCross.UseVisualStyleBackColor = false;
            this.RobertCross.Click += new System.EventHandler(this.RobertCross_Click);
            // 
            // PrewittAlgoritması
            // 
            this.PrewittAlgoritması.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PrewittAlgoritması.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrewittAlgoritması.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrewittAlgoritması.Location = new System.Drawing.Point(805, 268);
            this.PrewittAlgoritması.Name = "PrewittAlgoritması";
            this.PrewittAlgoritması.Size = new System.Drawing.Size(172, 63);
            this.PrewittAlgoritması.TabIndex = 28;
            this.PrewittAlgoritması.Text = "PREWİTT ALGORİTMASI";
            this.PrewittAlgoritması.UseVisualStyleBackColor = false;
            this.PrewittAlgoritması.Click += new System.EventHandler(this.PrewittAlgoritması_Click);
            // 
            // sobel
            // 
            this.sobel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.sobel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sobel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sobel.Location = new System.Drawing.Point(610, 268);
            this.sobel.Name = "sobel";
            this.sobel.Size = new System.Drawing.Size(172, 63);
            this.sobel.TabIndex = 27;
            this.sobel.Text = "SOBEL KENAR BULMA";
            this.sobel.UseVisualStyleBackColor = false;
            this.sobel.Click += new System.EventHandler(this.sobel_Click);
            // 
            // MDNFLT
            // 
            this.MDNFLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MDNFLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MDNFLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MDNFLT.Location = new System.Drawing.Point(418, 268);
            this.MDNFLT.Name = "MDNFLT";
            this.MDNFLT.Size = new System.Drawing.Size(172, 63);
            this.MDNFLT.TabIndex = 26;
            this.MDNFLT.Text = "MEDYAN FİLTRE";
            this.MDNFLT.UseVisualStyleBackColor = false;
            this.MDNFLT.Click += new System.EventHandler(this.MDNFLT_Click);
            // 
            // ORTFLT
            // 
            this.ORTFLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ORTFLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ORTFLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ORTFLT.Location = new System.Drawing.Point(221, 268);
            this.ORTFLT.Name = "ORTFLT";
            this.ORTFLT.Size = new System.Drawing.Size(181, 63);
            this.ORTFLT.TabIndex = 25;
            this.ORTFLT.Text = "ORTALAMA FİLTRE";
            this.ORTFLT.UseVisualStyleBackColor = false;
            this.ORTFLT.Click += new System.EventHandler(this.ORTFLT_Click);
            // 
            // btnknt
            // 
            this.btnknt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnknt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnknt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnknt.Location = new System.Drawing.Point(28, 268);
            this.btnknt.Name = "btnknt";
            this.btnknt.Size = new System.Drawing.Size(172, 63);
            this.btnknt.TabIndex = 24;
            this.btnknt.Text = "KONTRAS";
            this.btnknt.UseVisualStyleBackColor = false;
            this.btnknt.Click += new System.EventHandler(this.btnknt_Click);
            // 
            // Konvolüsyonyöntemi
            // 
            this.Konvolüsyonyöntemi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Konvolüsyonyöntemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Konvolüsyonyöntemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Konvolüsyonyöntemi.Location = new System.Drawing.Point(221, 483);
            this.Konvolüsyonyöntemi.Name = "Konvolüsyonyöntemi";
            this.Konvolüsyonyöntemi.Size = new System.Drawing.Size(181, 63);
            this.Konvolüsyonyöntemi.TabIndex = 37;
            this.Konvolüsyonyöntemi.Text = "KONVOLÜSYON YÖNTEMİ";
            this.Konvolüsyonyöntemi.UseVisualStyleBackColor = false;
            this.Konvolüsyonyöntemi.Click += new System.EventHandler(this.Konvolüsyonyöntemi_Click);
            // 
            // dondurma
            // 
            this.dondurma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.dondurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dondurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dondurma.Location = new System.Drawing.Point(28, 483);
            this.dondurma.Name = "dondurma";
            this.dondurma.Size = new System.Drawing.Size(172, 63);
            this.dondurma.TabIndex = 36;
            this.dondurma.Text = "DÖNDÜRME";
            this.dondurma.UseVisualStyleBackColor = false;
            this.dondurma.Click += new System.EventHandler(this.dondurma_Click);
            // 
            // zoom
            // 
            this.zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.zoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zoom.Location = new System.Drawing.Point(805, 378);
            this.zoom.Name = "zoom";
            this.zoom.Size = new System.Drawing.Size(172, 63);
            this.zoom.TabIndex = 35;
            this.zoom.Text = "ZOOM";
            this.zoom.UseVisualStyleBackColor = false;
            this.zoom.Click += new System.EventHandler(this.zoom_Click);
            // 
            // egmekaydırma
            // 
            this.egmekaydırma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.egmekaydırma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.egmekaydırma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.egmekaydırma.Location = new System.Drawing.Point(610, 378);
            this.egmekaydırma.Name = "egmekaydırma";
            this.egmekaydırma.Size = new System.Drawing.Size(172, 63);
            this.egmekaydırma.TabIndex = 34;
            this.egmekaydırma.Text = "EGME KAYDIRMA";
            this.egmekaydırma.UseVisualStyleBackColor = false;
            this.egmekaydırma.Click += new System.EventHandler(this.egmekaydırma_Click);
            // 
            // aynalama
            // 
            this.aynalama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.aynalama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aynalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aynalama.Location = new System.Drawing.Point(418, 378);
            this.aynalama.Name = "aynalama";
            this.aynalama.Size = new System.Drawing.Size(172, 63);
            this.aynalama.TabIndex = 33;
            this.aynalama.Text = "AYNALAMA";
            this.aynalama.UseVisualStyleBackColor = false;
            this.aynalama.Click += new System.EventHandler(this.aynalama_Click);
            // 
            // tasıma
            // 
            this.tasıma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tasıma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasıma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tasıma.Location = new System.Drawing.Point(221, 378);
            this.tasıma.Name = "tasıma";
            this.tasıma.Size = new System.Drawing.Size(181, 63);
            this.tasıma.TabIndex = 32;
            this.tasıma.Text = "TAŞIMA";
            this.tasıma.UseVisualStyleBackColor = false;
            this.tasıma.Click += new System.EventHandler(this.tasıma_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(418, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 63);
            this.button1.TabIndex = 38;
            this.button1.Text = "MORFOLOJİK GÖRÜNTÜ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(610, 483);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 63);
            this.button2.TabIndex = 39;
            this.button2.Text = "PERSPEKTİF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(805, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 63);
            this.button3.TabIndex = 40;
            this.button3.Text = "RENKLENDİRME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::gorüntüproje.Properties.Resources.png_transparent_computer_icons_exit_icon_miscellaneous_angle_text_thumbnail;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.Location = new System.Drawing.Point(924, 21);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 54);
            this.button16.TabIndex = 17;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1012, 602);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Konvolüsyonyöntemi);
            this.Controls.Add(this.dondurma);
            this.Controls.Add(this.zoom);
            this.Controls.Add(this.egmekaydırma);
            this.Controls.Add(this.aynalama);
            this.Controls.Add(this.tasıma);
            this.Controls.Add(this.RobertCross);
            this.Controls.Add(this.PrewittAlgoritması);
            this.Controls.Add(this.sobel);
            this.Controls.Add(this.MDNFLT);
            this.Controls.Add(this.ORTFLT);
            this.Controls.Add(this.btnknt);
            this.Controls.Add(this.BTN_HST);
            this.Controls.Add(this.BTN_ESK);
            this.Controls.Add(this.BTN_PRL);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.negatıfalma);
            this.Controls.Add(this.GRIYAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GRIYAP;
        private System.Windows.Forms.Button negatıfalma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button BTN_HST;
        private System.Windows.Forms.Button BTN_ESK;
        private System.Windows.Forms.Button BTN_PRL;
        private System.Windows.Forms.Button RobertCross;
        private System.Windows.Forms.Button PrewittAlgoritması;
        private System.Windows.Forms.Button sobel;
        private System.Windows.Forms.Button MDNFLT;
        private System.Windows.Forms.Button ORTFLT;
        private System.Windows.Forms.Button btnknt;
        private System.Windows.Forms.Button Konvolüsyonyöntemi;
        private System.Windows.Forms.Button dondurma;
        private System.Windows.Forms.Button zoom;
        private System.Windows.Forms.Button egmekaydırma;
        private System.Windows.Forms.Button aynalama;
        private System.Windows.Forms.Button tasıma;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

