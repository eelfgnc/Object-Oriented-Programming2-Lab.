using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz2
{
    public partial class Form1 : Form
    {
        double genelbahsis = 0.0;
        double sum = 0.0;
        double top;
        double tpl;
        double toplam;
        double bahşiş;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hesapcorba_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_hesapanayemek_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl_hesaptatlı_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_corba_TextChanged(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(txt_corba.Text, out sayi))
            {
                toplam = sayi * 4.5;
                lbl_hesapcorba.Text = "Toplam Fiyat " + (toplam).ToString("N2") + " TL";
                sum += toplam;
            }
            //else
            //{
            //    toplam = 0;
            //    lbl_hesapcorba.Text = "Toplam Fiyat " + (toplam).ToString("N2") + " TL";
            //    sum += toplam;
            //}
        }

        private void txt_anayemek_TextChanged(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(txt_anayemek.Text, out sayi))
            {
                tpl = sayi * 12;
                lbl_hesapanayemek.Text = "Toplam Fiyat " + (tpl).ToString("N2") + " TL";
                sum += tpl;
            }
            //else
            //{
            //    tpl = 0;
            //    lbl_hesapanayemek.Text = "Toplam Fiyat " + (tpl).ToString("N2") + " TL";
            //    sum += tpl;
            //}
        }

        private void txt_tatlı_TextChanged(object sender, EventArgs e)
        {
            int sayi;
            if (int.TryParse(txt_tatlı.Text, out sayi))
            {
                top = sayi * 2;
                lbl_hesaptatlı.Text = "Toplam Fiyat " + (top).ToString("N2") + " TL";
                sum += top;
            }
            //else
            //{
            //    top = 0;
            //    lbl_hesaptatlı.Text = "Toplam Fiyat " + (top).ToString("N2") + " TL";
            //    sum += top;
            //}

        }

        private void lbl_geneltoplam_Click(object sender, EventArgs e)
        {
            sum = top + tpl + toplam;
            lbl_geneltoplam.Text = "Genel Toplam " + sum.ToString("N2") + "TL";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void lbl_toplamhesap_Click(object sender, EventArgs e)
        {
            genelbahsis = sum + bahşiş;
            lbl_toplamhesap.Text = "Toplam Hesap " + genelbahsis.ToString("N2") + " TL";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chc_bahsis.Checked)
            {
                bahşiş = (sum * 5) / 100;
                lbl_bahşiş.Text = "Bahşiş " + bahşiş.ToString("N2") + " TL";
            }
            else 
            {
                bahşiş = 0;
                lbl_bahşiş.Text = "Bahşiş " +0.ToString("N2") + " TL";
            }
        }
    }
}
