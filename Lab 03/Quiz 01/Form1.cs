using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz1
{
    public partial class Form1 : Form
    {
        TextBox[] array = new TextBox[5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int min = 100, max = 0, sum = 0;
            double ave = 0.0;
            Random rndm = new Random();
            for (int i = 0; i < 5; i++)
            {
                TextBox textBox = new TextBox();

                int sayi = rndm.Next(0, 100);
                textBox.Text = sayi.ToString(); array[i] = textBox;
                textBox.Name = "textBox" + i.ToString(); 
                textBox.Location = new Point(50 + i * 20, 50 + i * 30);
                this.Controls.Add(textBox);
            }
            for (int i = 0; i < 5; i++)
            {
                sum += int.Parse(array[i].Text);
               if (int.Parse(array[i].Text) < min)
                {
                    min = int.Parse(array[i].Text);
                }
                if (int.Parse(array[i].Text) > max)
                {
                    max = int.Parse(array[i].Text);
                }
            }
            ave = (double) sum / 5;
            label.Text = "min value: " + min.ToString() + "  max value: " + max.ToString() + "  average value: " + ave.ToString();

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}
