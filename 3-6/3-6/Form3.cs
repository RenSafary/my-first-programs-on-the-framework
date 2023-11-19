using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single g;
            double a, b, x;
            if (Single.TryParse(textBox1.Text, out g) == false) 
            {
                MessageBox.Show("Введите число!");
                textBox1.Clear();
            }
            else
            {
                a = double.Parse(textBox1.Text);
                if (Single.TryParse(textBox2.Text, out g) == false)
                {
                    MessageBox.Show("Введите число!");
                    textBox2.Clear();
                }
                else
                {
                    b = double.Parse(textBox1.Text);
                    if (Single.TryParse(textBox3.Text, out g) == false)
                    {
                        MessageBox.Show("Введите число!");
                        textBox3.Clear();
                    }
                    else
                    {
                        x = double.Parse(textBox1.Text);
                        if (radioButton1.Checked)
                        {
                            x = (Math.Sqrt(x * x + b) - (b * b) * Math.Pow(Math.Sin(x + a), 3)) / x;
                            if (checkBox1.Checked)
                            {
                                textBox4.Text = x.ToString("F2");
                            }
                            else
                            {
                                textBox4.Text = Convert.ToString(x);
                            }
                        }
                        else
                        {
                            x = (Math.Pow(Math.Cos(x * x * x), 2) - x) / (Math.Sqrt((a * a) + (b * b)));
                            if (checkBox1.Checked)
                            {
                                textBox4.Text = x.ToString("F2");
                            }
                            else
                            {
                                textBox4.Text = Convert.ToString(x);
                            }
                        }
                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
