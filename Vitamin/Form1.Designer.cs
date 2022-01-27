namespace Vitamin
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.MeyveKutusu = new System.Windows.Forms.PictureBox();
            this.gecmis = new System.Windows.Forms.ListBox();
            this.MeyveKutusuFotograf = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.zamanlayici = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MeyveKutusu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vitamin Deposu";
            // 
            // MeyveKutusu
            // 
            this.MeyveKutusu.Location = new System.Drawing.Point(12, 63);
            this.MeyveKutusu.Name = "MeyveKutusu";
            this.MeyveKutusu.Size = new System.Drawing.Size(256, 256);
            this.MeyveKutusu.TabIndex = 1;
            this.MeyveKutusu.TabStop = false;
            // 
            // gecmis
            // 
            this.gecmis.BackColor = System.Drawing.Color.SeaShell;
            this.gecmis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gecmis.CausesValidation = false;
            this.gecmis.FormattingEnabled = true;
            this.gecmis.Items.AddRange(new object[] {
            " "});
            this.gecmis.Location = new System.Drawing.Point(631, 63);
            this.gecmis.Name = "gecmis";
            this.gecmis.Size = new System.Drawing.Size(350, 366);
            this.gecmis.TabIndex = 2;
            // 
            // MeyveKutusuFotograf
            // 
            this.MeyveKutusuFotograf.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MeyveKutusuFotograf.ImageStream")));
            this.MeyveKutusuFotograf.TransparentColor = System.Drawing.Color.Transparent;
            this.MeyveKutusuFotograf.Images.SetKeyName(0, "Armut");
            this.MeyveKutusuFotograf.Images.SetKeyName(1, "Cilek");
            this.MeyveKutusuFotograf.Images.SetKeyName(2, "Elma");
            this.MeyveKutusuFotograf.Images.SetKeyName(3, "Greyfurt");
            this.MeyveKutusuFotograf.Images.SetKeyName(4, "Mandalina");
            this.MeyveKutusuFotograf.Images.SetKeyName(5, "Portakal");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Narenciye";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(244, 333);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "Katı Meyve Sıkacagı";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 117);
            this.label2.TabIndex = 5;
            this.label2.Text = "Meyve        :  \r\n\r\ngram           :  \r\n\r\nA vitamini   :\r\n\r\nC vitamini   :\r\n\r\nVer" +
    "im           :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Meyve Adi\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Verim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(224, 443);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 35);
            this.label8.TabIndex = 11;
            this.label8.Text = "K";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrange;
            this.label9.Location = new System.Drawing.Point(254, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 35);
            this.label9.TabIndex = 12;
            this.label9.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Location = new System.Drawing.Point(284, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 35);
            this.label11.TabIndex = 14;
            this.label11.Text = "R";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.MediumPurple;
            this.label12.Location = new System.Drawing.Point(380, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 35);
            this.label12.TabIndex = 15;
            this.label12.Text = "I";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.YellowGreen;
            this.label13.Location = new System.Drawing.Point(343, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 35);
            this.label13.TabIndex = 16;
            this.label13.Text = "Ş";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.HotPink;
            this.label14.Location = new System.Drawing.Point(313, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 35);
            this.label14.TabIndex = 17;
            this.label14.Text = "I";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Chocolate;
            this.label15.Location = new System.Drawing.Point(415, 443);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 35);
            this.label15.TabIndex = 18;
            this.label15.Text = "M";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(43, 534);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(260, 54);
            this.label10.TabIndex = 19;
            this.label10.Text = "A vitamini            :          0 mg         \r\n\r\nSıvı                      :    " +
    "      0 mg                ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(472, 534);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 54);
            this.label16.TabIndex = 20;
            this.label16.Text = "C vitamini            :          0 mg           \r\n\r\nPure                     :   " +
    "       0 mg           ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(135, 17);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 25);
            this.label17.TabIndex = 21;
            this.label17.Text = "60";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(12, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 25);
            this.label18.TabIndex = 22;
            this.label18.Text = "Süre    :    ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(307, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 24);
            this.label19.TabIndex = 23;
            this.label19.Text = "DOĞRU ";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(307, 271);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 24);
            this.label20.TabIndex = 24;
            this.label20.Text = "YANLIŞ";
            this.label20.Visible = false;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // zamanlayici
            // 
            this.zamanlayici.Interval = 1000;
            this.zamanlayici.Tick += new System.EventHandler(this.zamanlayici_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1006, 711);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gecmis);
            this.Controls.Add(this.MeyveKutusu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vitamin Deposu Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MeyveKutusu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MeyveKutusu;
        private System.Windows.Forms.ListBox gecmis;
        private System.Windows.Forms.ImageList MeyveKutusuFotograf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Timer zamanlayici;
    }
}

