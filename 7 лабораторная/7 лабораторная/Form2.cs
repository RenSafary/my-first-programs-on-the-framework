using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_лабораторная
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Close();
            fr1.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, x, x1, x2, t, t1, s, y, y1, y2;
            textBox1.Text = "";
            Single g;
            if (Single.TryParse(textBox2.Text, out g) == false)
            {
                MessageBox.Show
                    ("Введите число!");
                textBox2.Clear();
            }
            else
            {
                a = Double.Parse(textBox2.Text);
                if (Single.TryParse(textBox3.Text, out g) == false)
                {
                    MessageBox.Show
                        ("Введите число!");
                    textBox3.Clear();
                }
                else
                {
                    x = Double.Parse(textBox3.Text);
                    if (Single.TryParse(textBox4.Text, out g) == false)
                    {
                        MessageBox.Show
                            ("Введите число!");
                        textBox4.Clear();
                    }
                    else
                    {
                        x1 = Double.Parse(textBox4.Text);
                        if (Single.TryParse(textBox5.Text, out g) == false)
                        {
                            MessageBox.Show
                                ("Введите число!");
                            textBox5.Clear();
                        }
                        else
                        {
                            x2 = Double.Parse(textBox5.Text);
                            if (Single.TryParse(textBox6.Text, out g) == false)
                            {
                                MessageBox.Show
                                    ("Введите число!");
                                textBox6.Clear();
                            }
                            else
                            {
                                t = Double.Parse(textBox6.Text);
                                if (Single.TryParse(textBox7.Text, out g) == false)
                                {
                                    MessageBox.Show
                                        ("Введите число!");
                                    textBox7.Clear();
                                }
                                else
                                {
                                    t1 = Double.Parse(textBox7.Text);
                                    if (Single.TryParse(textBox8.Text, out g) == false)
                                    {
                                        MessageBox.Show
                                            ("Введите число!");
                                        textBox8.Clear();
                                    }
                                    else
                                    {
                                        s = Double.Parse(textBox8.Text);
                                        if (x < 0.5)
                                        {
                                            y = x * x - Math.Sin(x + Math.PI);
                                            textBox1.Text += "x = " + Convert.ToString(x) + " y = " + Convert.ToString(y) + "\r\n";
                                        }
                                        else MessageBox.Show("!!! x<0,5 !!!"); textBox3.Clear();
                                        if (x1 <= 1.2 && x1 >= 0.5)
                                        {
                                            for (double b = a; b >= t && b <= t1; b += s)
                                            {
                                                y1 = a * Math.Pow(Math.Sqrt(x1), 3) + a * Math.Sqrt(3 * x1 + a);
                                                textBox1.Text += "x1 = " + Convert.ToString(x1) + ", y1 = " + Convert.ToString(y1) + "\r\n";
                                            }
                                        }
                                        else MessageBox.Show("!!! 0,5 <= x1 <= 1,2 !!!"); textBox4.Clear();
                                        if (x2 > 1.2)
                                        {
                                            for (double b = a; b >= t && b <= t1; b += s)
                                            {
                                                y2 = Math.Log(x2 + a * x2);
                                                textBox1.Text += "x2 = " + Convert.ToString(x2) + ", y2 = " + Convert.ToString(y2) + "\r\n";
                                            }
                                        }
                                        else MessageBox.Show("!!! x2 > 1,2 !!!"); textBox5.Clear();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
