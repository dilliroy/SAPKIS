﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

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
                        if (b != 0) a = a / b;
                        else
                        {
                            label1.Text = "Ошибка работы!!!";
                            textBox1.Clear();
                            a = 0;
                            b = 0;
                        }
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
                        if (b != 0) a = a / b;
                        else
                        {
                            label1.Text = "Ошибка работы!!!";
                            textBox1.Clear();
                            a = 0;
                            b = 0;
                        }
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
                label1.Text = "Ошибка работы!!!";
                textBox1.Clear();
                a = 0;
                b = 0;
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

        private void button24_Click(object sender, EventArgs e)
        {
            const string name = "MyApplication";
            string ExePath = System.Windows.Forms.Application.ExecutablePath;
            Microsoft.Win32.RegistryKey reg;
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                reg.SetValue(name, ExePath);
                reg.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey reg;
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
            try
            {
                reg.DeleteValue("MyApplication");
                reg.Close();

            }
            catch { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            label1.Text = "";
        }
    }
}
