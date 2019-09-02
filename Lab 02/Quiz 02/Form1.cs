using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2
{
    public partial class Form1 : Form
    {
        int[] array;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txt_star_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            int count = 0;
            Random temp = new Random();
            int size = int.Parse(txt_size.Text);
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = temp.Next(0, 10);
                txt_star.Text += array[i].ToString() + "  ";

            }
            txt_star.Text += Environment.NewLine;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (array[j] == i)
                    {
                        count++;
                    }

                }
                txt_star.Text += i.ToString() + "\t";
                for (int k = 0; k < count; k++)
                {
                    txt_star.Text += "*";
                }
                txt_star.Text += Environment.NewLine;
                count = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
