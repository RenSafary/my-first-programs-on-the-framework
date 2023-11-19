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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Single g;
            Double x=0, y=0, z=0;
            if (Single.TryParse(textBox1.Text, out g) == false)
            {
                MessageBox.Show
                    ("Введите число!");
                textBox1.Clear();
            }
            else x = Double.Parse(textBox1.Text);
            if (Single.TryParse(textBox1.Text, out g) == false)
            {
                MessageBox.Show
                    ("Введите число!");
                textBox1.Clear();
            }
            else y = Double.Parse(textBox2.Text);
            if (checkBox1.Checked)
            {
                if (radioButton1.Checked) z = x + y;
                if (radioButton2.Checked) z = x - y;
                if (radioButton3.Checked) z = x * y;
                if (radioButton4.Checked) z = x / y;
                textBox3.Text = Convert.ToString(z);
            }
            else
            {
                if (radioButton1.Checked) z = x + y;
                if (radioButton2.Checked) z = x - y;
                if (radioButton3.Checked) z = x * y;
                if (radioButton4.Checked) z = x / y;
                textBox3.Text = string.Format("{0,8:F4}", z);
            }
        }
    }
}
