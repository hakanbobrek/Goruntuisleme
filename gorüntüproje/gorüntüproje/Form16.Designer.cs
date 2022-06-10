namespace gorüntüproje
{
    partial class Form16
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ZOOM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 145;
            this.label2.Text = "ZOOM YAP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(47, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 79);
            this.button1.TabIndex = 140;
            this.button1.Text = "RESİM  SEÇ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::gorüntüproje.Properties.Resources.png_transparent_computer_icons_exit_icon_miscellaneous_angle_text_thumbnail;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button16.Location = new System.Drawing.Point(316, -1);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 57);
            this.button16.TabIndex = 147;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::gorüntüproje.Properties.Resources.png_transparent_computer_icons_undo_right_arrow_angle_text_logo_thumbnail;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(259, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 57);
            this.button2.TabIndex = 146;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(46, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(22, 87);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(336, 45);
            this.trackBar1.TabIndex = 148;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ZOOM
            // 
            this.ZOOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ZOOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZOOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ZOOM.Location = new System.Drawing.Point(228, 589);
            this.ZOOM.Name = "ZOOM";
            this.ZOOM.Size = new System.Drawing.Size(169, 79);
            this.ZOOM.TabIndex = 149;
            this.ZOOM.Text = "ZOOM YAP";
            this.ZOOM.UseVisualStyleBackColor = false;
            this.ZOOM.Click += new System.EventHandler(this.ZOOM_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(22, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 412);
            this.panel1.TabIndex = 150;
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(531, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ZOOM);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form16";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form16";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ZOOM;
        private System.Windows.Forms.Panel panel1;
    }
}