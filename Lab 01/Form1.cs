using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntoplama_Click(object sender, EventArgs e)
        {
            if (txtnumber1.Text.Length == 0 || txtnumber2.Text.Length == 0)
            {
                lblResult.Text = "Result";
            }
            else
            {
                double toplama;
                toplama = double.Parse(txtnumber1.Text) + double.Parse(txtnumber2.Text);
                lblResult.Text = toplama.ToString("0.00");
            }
        }

        private void btncikarma_Click(object sender, EventArgs e)
        {
            if (txtnumber1.Text.Length == 0 || txtnumber2.Text.Length == 0)
            {
                lblResult.Text = "Result";
            }
            else
            {
                double cikarma;
                cikarma = double.Parse(txtnumber1.Text) - double.Parse(txtnumber2.Text);
                lblResult.Text = cikarma.ToString("0.00");
            }
        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            if (txtnumber1.Text.Length == 0 || txtnumber2.Text.Length == 0)
            {
                lblResult.Text = "Result";
            }
            else
            {
                double carpma;
                carpma = double.Parse(txtnumber1.Text) * double.Parse(txtnumber2.Text);
                lblResult.Text = carpma.ToString("0.00");
            }
        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            if (txtnumber1.Text.Length == 0 || txtnumber2.Text.Length == 0)
            {
                lblResult.Text = "Result";
            }
            else
            {
                double bolme;
                bolme = double.Parse(txtnumber1.Text) / double.Parse(txtnumber2.Text);
                lblResult.Text = bolme.ToString("0.00");
            }
        }
    }
}
