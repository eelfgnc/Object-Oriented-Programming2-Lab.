namespace quiz2
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
            this.lbl_corba = new System.Windows.Forms.Label();
            this.lbl_anayemek = new System.Windows.Forms.Label();
            this.lbl_tatlı = new System.Windows.Forms.Label();
            this.txt_corba = new System.Windows.Forms.TextBox();
            this.txt_anayemek = new System.Windows.Forms.TextBox();
            this.txt_tatlı = new System.Windows.Forms.TextBox();
            this.lbl_hesapcorba = new System.Windows.Forms.Label();
            this.lbl_hesapanayemek = new System.Windows.Forms.Label();
            this.lbl_hesaptatlı = new System.Windows.Forms.Label();
            this.lbl_geneltoplam = new System.Windows.Forms.Label();
            this.chc_bahsis = new System.Windows.Forms.CheckBox();
            this.lbl_bahşiş = new System.Windows.Forms.Label();
            this.lbl_toplamhesap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_corba
            // 
            this.lbl_corba.AutoSize = true;
            this.lbl_corba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_corba.Location = new System.Drawing.Point(40, 25);
            this.lbl_corba.Name = "lbl_corba";
            this.lbl_corba.Size = new System.Drawing.Size(254, 16);
            this.lbl_corba.TabIndex = 0;
            this.lbl_corba.Text = "Çorba (Birim Fiyatı 4,5 TL)                   ADET";
            this.lbl_corba.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_anayemek
            // 
            this.lbl_anayemek.AutoSize = true;
            this.lbl_anayemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_anayemek.Location = new System.Drawing.Point(40, 62);
            this.lbl_anayemek.Name = "lbl_anayemek";
            this.lbl_anayemek.Size = new System.Drawing.Size(254, 16);
            this.lbl_anayemek.TabIndex = 1;
            this.lbl_anayemek.Text = "Ana Yemek (Birim Fiyatı 12 TL)         ADET";
            this.lbl_anayemek.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_tatlı
            // 
            this.lbl_tatlı.AutoSize = true;
            this.lbl_tatlı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tatlı.Location = new System.Drawing.Point(40, 97);
            this.lbl_tatlı.Name = "lbl_tatlı";
            this.lbl_tatlı.Size = new System.Drawing.Size(254, 16);
            this.lbl_tatlı.TabIndex = 2;
            this.lbl_tatlı.Text = "Tatlı (Birim Fiyatı 2 TL)                          ADET";
            this.lbl_tatlı.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_corba
            // 
            this.txt_corba.Location = new System.Drawing.Point(309, 24);
            this.txt_corba.Name = "txt_corba";
            this.txt_corba.Size = new System.Drawing.Size(100, 20);
            this.txt_corba.TabIndex = 3;
            this.txt_corba.TextChanged += new System.EventHandler(this.txt_corba_TextChanged);
            // 
            // txt_anayemek
            // 
            this.txt_anayemek.Location = new System.Drawing.Point(309, 62);
            this.txt_anayemek.Name = "txt_anayemek";
            this.txt_anayemek.Size = new System.Drawing.Size(100, 20);
            this.txt_anayemek.TabIndex = 4;
            this.txt_anayemek.TextChanged += new System.EventHandler(this.txt_anayemek_TextChanged);
            // 
            // txt_tatlı
            // 
            this.txt_tatlı.Location = new System.Drawing.Point(309, 97);
            this.txt_tatlı.Name = "txt_tatlı";
            this.txt_tatlı.Size = new System.Drawing.Size(100, 20);
            this.txt_tatlı.TabIndex = 5;
            this.txt_tatlı.TextChanged += new System.EventHandler(this.txt_tatlı_TextChanged);
            // 
            // lbl_hesapcorba
            // 
            this.lbl_hesapcorba.AutoSize = true;
            this.lbl_hesapcorba.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hesapcorba.Location = new System.Drawing.Point(431, 27);
            this.lbl_hesapcorba.Name = "lbl_hesapcorba";
            this.lbl_hesapcorba.Size = new System.Drawing.Size(119, 16);
            this.lbl_hesapcorba.TabIndex = 6;
            this.lbl_hesapcorba.Text = "Toplam Fiyat  0 TL";
            this.lbl_hesapcorba.Click += new System.EventHandler(this.lbl_hesapcorba_Click);
            // 
            // lbl_hesapanayemek
            // 
            this.lbl_hesapanayemek.AutoSize = true;
            this.lbl_hesapanayemek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hesapanayemek.Location = new System.Drawing.Point(431, 66);
            this.lbl_hesapanayemek.Name = "lbl_hesapanayemek";
            this.lbl_hesapanayemek.Size = new System.Drawing.Size(119, 16);
            this.lbl_hesapanayemek.TabIndex = 7;
            this.lbl_hesapanayemek.Text = "Toplam Fiyat  0 TL";
            this.lbl_hesapanayemek.Click += new System.EventHandler(this.lbl_hesapanayemek_Click);
            // 
            // lbl_hesaptatlı
            // 
            this.lbl_hesaptatlı.AutoSize = true;
            this.lbl_hesaptatlı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hesaptatlı.Location = new System.Drawing.Point(431, 101);
            this.lbl_hesaptatlı.Name = "lbl_hesaptatlı";
            this.lbl_hesaptatlı.Size = new System.Drawing.Size(119, 16);
            this.lbl_hesaptatlı.TabIndex = 8;
            this.lbl_hesaptatlı.Text = "Toplam Fiyat  0 TL";
            this.lbl_hesaptatlı.Click += new System.EventHandler(this.lbl_hesaptatlı_Click);
            // 
            // lbl_geneltoplam
            // 
            this.lbl_geneltoplam.AutoSize = true;
            this.lbl_geneltoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_geneltoplam.Location = new System.Drawing.Point(433, 137);
            this.lbl_geneltoplam.Name = "lbl_geneltoplam";
            this.lbl_geneltoplam.Size = new System.Drawing.Size(117, 16);
            this.lbl_geneltoplam.TabIndex = 9;
            this.lbl_geneltoplam.Text = "Genel toplam 0 TL";
            this.lbl_geneltoplam.Click += new System.EventHandler(this.lbl_geneltoplam_Click);
            // 
            // chc_bahsis
            // 
            this.chc_bahsis.AutoSize = true;
            this.chc_bahsis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chc_bahsis.Location = new System.Drawing.Point(292, 174);
            this.chc_bahsis.Name = "chc_bahsis";
            this.chc_bahsis.Size = new System.Drawing.Size(128, 20);
            this.chc_bahsis.TabIndex = 10;
            this.chc_bahsis.Text = "Bahşiş Ekle (5%)";
            this.chc_bahsis.UseVisualStyleBackColor = true;
            this.chc_bahsis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbl_bahşiş
            // 
            this.lbl_bahşiş.AutoSize = true;
            this.lbl_bahşiş.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bahşiş.Location = new System.Drawing.Point(433, 177);
            this.lbl_bahşiş.Name = "lbl_bahşiş";
            this.lbl_bahşiş.Size = new System.Drawing.Size(78, 16);
            this.lbl_bahşiş.TabIndex = 11;
            this.lbl_bahşiş.Text = "Bahşiş 0 TL";
            this.lbl_bahşiş.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_toplamhesap
            // 
            this.lbl_toplamhesap.AutoSize = true;
            this.lbl_toplamhesap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_toplamhesap.Location = new System.Drawing.Point(436, 216);
            this.lbl_toplamhesap.Name = "lbl_toplamhesap";
            this.lbl_toplamhesap.Size = new System.Drawing.Size(128, 16);
            this.lbl_toplamhesap.TabIndex = 12;
            this.lbl_toplamhesap.Text = "Toplam Hesap 0 TL";
            this.lbl_toplamhesap.Click += new System.EventHandler(this.lbl_toplamhesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 299);
            this.Controls.Add(this.lbl_toplamhesap);
            this.Controls.Add(this.lbl_bahşiş);
            this.Controls.Add(this.chc_bahsis);
            this.Controls.Add(this.lbl_geneltoplam);
            this.Controls.Add(this.lbl_hesaptatlı);
            this.Controls.Add(this.lbl_hesapanayemek);
            this.Controls.Add(this.lbl_hesapcorba);
            this.Controls.Add(this.txt_tatlı);
            this.Controls.Add(this.txt_anayemek);
            this.Controls.Add(this.txt_corba);
            this.Controls.Add(this.lbl_tatlı);
            this.Controls.Add(this.lbl_anayemek);
            this.Controls.Add(this.lbl_corba);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_corba;
        private System.Windows.Forms.Label lbl_anayemek;
        private System.Windows.Forms.Label lbl_tatlı;
        private System.Windows.Forms.TextBox txt_corba;
        private System.Windows.Forms.TextBox txt_anayemek;
        private System.Windows.Forms.TextBox txt_tatlı;
        private System.Windows.Forms.Label lbl_hesapcorba;
        private System.Windows.Forms.Label lbl_hesapanayemek;
        private System.Windows.Forms.Label lbl_hesaptatlı;
        private System.Windows.Forms.Label lbl_geneltoplam;
        private System.Windows.Forms.CheckBox chc_bahsis;
        private System.Windows.Forms.Label lbl_bahşiş;
        private System.Windows.Forms.Label lbl_toplamhesap;
    }
}

