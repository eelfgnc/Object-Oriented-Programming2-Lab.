using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        int[] A = new int[5];
        int[] B = new int[5];

        void mergewithunique(int[] a1, int[] a2)
        {
            string sayi;
            int[] result = new int[a1.Length + a2.Length];
            int listind = 0;
            for (int i = 0; i < a1.Length; i++)
            {
                result[listind++] = a1[i];
            }
            for (int i = 0; i < a2.Length; i++)
            {
                result[listind++] = a2[i];
            }
            for (int i = 0; i < result.Length; i++)
            {
                int j;
                for (j = i + 1; j < result.Length; j++)
                {
                    if (result[i] == result[j])
                    {
                        break;
                    }
                    else if (j == result.Length-1)
                    {
                        listView1.Items.Add(result[i].ToString());
                    }
                }
            }
        }
        void ciftler(int[] a1, int[] a2)
        {
            int[] result = new int[a1.Length + a2.Length];
            int listind = 0;
            for (int i = 0; i < a1.Length; ++i)
            {
                result[listind++] = a1[i];
            }
            for (int i = 0; i < a2.Length; ++i)
            {
                result[listind++] = a2[i];
            }
            for (int i = 0; i < result.Length - 1; i++)
            {
                int j;
                for (j = i + 1; j < result.Length; j++)
                {
                    if (result[i] == result[j])
                    {
                        listView2.Items.Add(result[i].ToString());
                        break;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
              mergewithunique(A, B);
            listView2.Items.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ciftler(A, B);
            listView1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random temp = new Random();
            for (int i = 0; i < 5; i++)
            {
                A[i] = temp.Next(0, 20);
                B[i] = temp.Next(0, 20);
                textBox1.Text += A[i].ToString() + "   ";
            }
            textBox1.Text += "   | | |    ";
            for (int i = 0; i < 5; i++)
            {
                textBox1.Text += B[i].ToString() + "   ";
            }

        }
      
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
