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
        
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0") textBox1.Text += (sender as Button).Text;
            else
            {
                textBox1.Clear();
                textBox1.Text += (sender as Button).Text;
            }
        }
        
        private void button13_Click(object sender, EventArgs e)
        {
            if (a == 0 && textBox1.Text != "") a = Convert.ToDouble(textBox1.Text);
            else if (textBox1.Text != "")
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
                znak = (sender as Button).Text[0];
                textBox1.Text = a.ToString();
            }
            else textBox1.Text = a.ToString();
            label1.Text = "";
            a = 0;
            b = 0;
        }
        double a = 0, b = 0;
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
            if (textBox1.Text != "" && textBox1.Text[0] == '-' && textBox1.Text.Length == 2)
                textBox1.Clear();
            else if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (a == 0 && textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
            }
            else if (textBox1.Text != "")
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
            switch (znak)
            {
                case '+':
                    label1.Text = a.ToString() + "+";
                    break;
                case '-':
                    label1.Text = a.ToString() + "-";
                    break;
                case 'x':
                    label1.Text = a.ToString() + "x";
                    break;
                case '/':
                    label1.Text = a.ToString() + "/";
                    break;
            }
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
            if (textBox1.Text != "" && textBox1.Text[0] != '-')
            {
                a = Convert.ToDouble(textBox1.Text);
                a = Math.Sqrt(a);
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
            }
            else if (textBox1.Text != "" && textBox1.Text[0] == '-')
            {
                textBox1.Text = "Ошибка работы!!!";
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button18.Enabled = false;
                button19.Enabled = false;
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;
                button23.Enabled = false;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                a = 1 / a;
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                a = Math.Pow(a, 2);
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text.Contains(","));
            else textBox1.Text += (sender as Button).Text;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                a = Convert.ToDouble(textBox1.Text);
                a = a / 100;
                textBox1.Text = a.ToString();
                a = 0;
                b = 0;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            a = 0;
            b = 0;
            label1.Text = "";
        }
    }
}
