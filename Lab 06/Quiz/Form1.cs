using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz
{
    public partial class Form1 : Form
    {
        int i = 0;
        int indis;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i % 5;
            pictureBox1.Image = Image.FromFile(@"C:\Users\ELİF\Pictures\Saved Pictures\Resim" + i.ToString() + ".jpg");
            i = i + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            indis = listBox1.SelectedIndex;
            if (indis == -1)
            {
                indis = 0;
            }
            
            pictureBox2.Image = Image.FromFile(@"C:\Users\ELİF\Pictures\Saved Pictures\" + listBox1.Items[indis] + ".jpg");
        
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indis2 = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(indis2);
           
        }
    }
}
