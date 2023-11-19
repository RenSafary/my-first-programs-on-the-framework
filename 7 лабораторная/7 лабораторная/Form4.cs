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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            int a = 0, b = 0, c = 0, k = 0;
            for (a = 0; a <= 20; a++)
            {
                for (b = 0; b <= 20; b++)
                {
                    for (c = 0; c <= 20; c++)
                    {
                        if ((a * a) + (b * b) == (c * c))
                        {
                            textBox1.Text += "a = " + Convert.ToString(a) + "\r\n";
                            textBox1.Text += "b = " + Convert.ToString(b) + "\r\n";
                            textBox1.Text += "c = " + Convert.ToString(c) + "\r\n";
                            textBox1.Text += "---------------" + "\r\n";
                            k++;
                        }
                    }
                }
            }
            textBox1.Text += "k = " + Convert.ToString(k) + "\r\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Close();
            fr1.Show();
        }
    }
}
