using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1
{
    public partial class Form1 : Form
    {
        int size;
        double min = double.MaxValue;
        double max = double.MinValue;
        double ave = 0.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void txt_size_TextChanged(object sender, EventArgs e)
        {
            size = int.Parse(txt_size.Text);
        }
        private void txt_array_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] array = new double[size];
            Random temp = new Random();
            for(int i = 0; i < size; i++)
            {
                array[i] = temp.NextDouble();
                txt_array.Text += array[i].ToString("N2") + Environment.NewLine;
            }
            for (int i = 0; i < size; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            for (int i = 0; i < size; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < size; i++)
            {
                ave += array[i];
            }
            ave = ave / size;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {;
            txt_array.Text += "Minimum value: " + min.ToString("N2") + Environment.NewLine;
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            
            
            txt_array.Text += "Maximum value: " + max.ToString("N2") + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_size_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btn_ave_Click(object sender, EventArgs e)
        {
           
            txt_array.Text += "Average value: " + ave.ToString("N2") + Environment.NewLine;
        }
    }
}
