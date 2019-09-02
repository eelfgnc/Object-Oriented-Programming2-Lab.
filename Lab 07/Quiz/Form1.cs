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
        SimpleCalculator s = new SimpleCalculator();
        MathCalculator mc = new MathCalculator();
        StatisticCalculator sc = new StatisticCalculator();
        TrigonometricCalculator tc = new TrigonometricCalculator();
        
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.Cos(n1);
            textBox3.Text = result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.ASin(n1);
            textBox3.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.ACos(n1);
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.Cot(n1);
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.Tan(n1);
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.Sin(n1);
            textBox3.Text = result.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = tc.ATan(n1);
            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox2.Text);
            double n2 = double.Parse(textBox4.Text);
            double result = s.Add(n1, n2);
            textBox3.Text = result.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = tc.Power(n1,n2);
            textBox3.Text = result.ToString();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double result = mc.Sqrt(n1);
            textBox3.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = s.Divide(n1, n2);
            textBox3.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = s.Multiply(n1, n2);
            textBox3.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox4.Text);
            double n2 = double.Parse(textBox2.Text);
            double result = s.Subtract(n1, n2);
            textBox3.Text = result.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            double[] array = new double[5];
            int i = 0;
            string dizi = textBox7.Text;
            string[] parcalar = dizi.Split(' ');
            foreach (string item in parcalar)
            {
                textBox1.Text += item + " ";
                array[i] = double.Parse(item);
                i++;
            }
            double mean = sc.Mean(array);
            textBox1.Text += mean.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            double[] array = new double[5];
            int i = 0;
            string dizi = textBox7.Text;
            string[] parcalar = dizi.Split(' ');
            foreach (string item in parcalar)
            {
                textBox1.Text += item + " ";
                array[i] = double.Parse(item);
                i++;
            }
            double mean = sc.Mean(array);
            double std = sc.Std(array, mean);
            textBox1.Text += std.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            double[] array = new double[5];
            int i = 0;
            string dizi = textBox7.Text;
            string[] parcalar = dizi.Split(' ');
            foreach (string item in parcalar)
            {
                textBox1.Text += item + " ";
                array[i] = double.Parse(item);
                i++;
            }
            double mean = sc.Mean(array);
            double var = sc.Var(array, mean);
            textBox1.Text += var.ToString(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
