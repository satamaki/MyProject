using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && 
                !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Calculation cl = new Calculation(a, b);
                label1.Text = cl.execute("+").ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Calculation cl = new Calculation(a, b);
                label1.Text = cl.execute("-").ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Calculation cl = new Calculation(a, b);
                label1.Text = cl.execute("*").ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);
                Calculation cl = new Calculation(a, b);
                label1.Text = cl.execute("/").ToString();
            }
        }
    }
}
