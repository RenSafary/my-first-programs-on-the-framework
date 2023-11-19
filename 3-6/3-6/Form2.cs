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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y=Math.Sin(x)-Math.Exp(x)+0.25;
            textBox2.Text = Convert.ToString(y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
