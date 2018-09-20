using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            
                b = Convert.ToDouble(textBox1.Text);
                switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case 'x':
                        c = a * b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                }
            textBox1.Text = c.ToString();
            a = 0;
            b = 0;
            c = 0;
        }

        double a = 0, b = 0, c = 0;
        char znak = 'a';

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (a == 0) a = Convert.ToDouble(textBox1.Text);
            else
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (znak)
                {
                    case '+':
                        a = a + b;
                        break;
                    case '-':
                        a = a - b;
                        break;
                    case 'x':
                        a = a * b;
                        break;
                    case '/':
                        a = a / b;
                        break;
                }
            }
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = Math.Sqrt(a);
            textBox1.Text = c.ToString();
            c = 0;
            a = 0;
            b = 0;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = 1 / a;
            textBox1.Text = c.ToString();
            c = 0;
            a = 0;
            b = 0;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = a / 100;
            textBox1.Text = c.ToString();
            c = 0;
            a = 0;
            b = 0;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            c = Math.Pow(a, 2);
            textBox1.Text = c.ToString();
            c = 0;
            a = 0;
            b = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            c = 0;
        }
    }
}
