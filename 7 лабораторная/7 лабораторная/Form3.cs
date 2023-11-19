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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Close();
            fr1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                double s, a, Eps;
                long k;
                Eps = Double.Parse(textBox1.Text);
                s = 0; k = 1;
                do
                {
                    a = (k * 1 * 2 * 3 * 4 * 5) / (2 * k);
                    s = s + a;
                    k++;
                }
                while (Math.Abs(a) > Eps);
                textBox1.Text = Convert.ToString(s);
                textBox2.Text = Convert.ToString(k - 1);
            }
            else
            {
                double s, a;
                byte n;
                n = Byte.Parse(textBox1.Text);
                textBox1.Clear();
                s = 0;
                for (byte k = 1; k <= n; k += 1)
                {
                    a = (k * 1 * 2 * 3 * 4 * 5) / (2 * k);
                    s = s + a;
                    textBox1.Text = string.Format("{0}", s);
                }
            }
        }
    }
}
