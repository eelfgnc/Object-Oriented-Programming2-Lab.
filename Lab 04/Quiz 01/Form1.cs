using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz4
{
    public partial class Form1 : Form
    {
        string[] bilgi = new string[10];
        string[] bilgiparcalari; 
        string cinsiyett, yasGrubuu, adSoyadd;
        int i = 0;
        void MusteriEkle(String adSoyad, String cinsiyet, String yasGrubu)
        {
            bilgi[i] = adSoyad + "," + cinsiyet + "," + yasGrubu;
        }
        string YasGrubuIstatistigi()
        {
            double gnc, ytskn, ysl;
            double genc = 0, yetiskin = 0, yasli = 0;
            for (int k = 0; k < i; k++)
            {
                bilgiparcalari = bilgi[k].Split(',');
                if (bilgiparcalari[2] == "Genc") genc++;
                else if (bilgiparcalari[2] == "Yetiskin") yetiskin++;
                else if (bilgiparcalari[2] == "Yasli") yasli++;
            }
            gnc = (double)(genc / i) * 100;
            ytskn = (double)(yetiskin / i) * 100;
            ysl = (double)(yasli / i) * 100;
            string metin;
            metin = "Grupta " + genc.ToString() + " Genç, " + yetiskin.ToString() + " Yetişkin, " + yasli.ToString() + " Yaslı Bulunmaktadir. Grubun %" +
                     gnc.ToString("N2") + "'i genclerden, %" + ytskn.ToString("N2") + "'i yetiskinlerden, %" + ysl.ToString("N2") + "'i yaslilardan olusmaktadir.";
            return metin;
            
        }
        string CinsiyetIstatistigi()
        {
            double bayistatisligi, bayanistattisligi;
            double byy = 0, bynn = 0;
            for (int k = 0; k < i; k++)
            {
                bilgiparcalari = bilgi[k].Split(',');
                if (bilgiparcalari[1] == "Bay") byy++;
                else if (bilgiparcalari[1] == "Bayan") bynn++;
            }
            bayistatisligi = (double)(byy / i) * 100;
            bayanistattisligi = (double)(bynn / i) * 100;
            string metin;
            metin = "Grupta " + byy.ToString() + " Bay, " + bynn.ToString() + " Bayan Bulunmaktadir. Grubun %" +
                     bayistatisligi.ToString("N2") + "'ini Baylar, kalan %" + bayanistattisligi.ToString("N2") + "'ini Bayanlar olusturmaktadir.";
            return metin;
           
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string y = CinsiyetIstatistigi();
            MessageBox.Show(y, "Cinsiyet Istatisligi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string x = YasGrubuIstatistigi();
            MessageBox.Show(x, "Yas Grup Istatisligi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tx_adsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) cinsiyett = "Bay";
            else if (radioButton2.Checked) cinsiyett = "Bayan";

            if (radioButton3.Checked) yasGrubuu = "Yetiskin";
            else if (radioButton4.Checked) yasGrubuu = "Genc";
            else if (radioButton5.Checked) yasGrubuu = "Yasli";

            adSoyadd = tx_adsoyad.Text;
            MusteriEkle(adSoyadd, cinsiyett, yasGrubuu);
            label1.Text += bilgi[i].ToString() + Environment.NewLine;
            i = i + 1;
        }
    }
}
