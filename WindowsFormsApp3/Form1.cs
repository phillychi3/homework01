using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 255, 255);
            textBox1.Text = ("2222222222222222");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 0, 255);
            textBox1.Text = ("33333333333333333");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 0);
            textBox1.Text = ("444444444444444444");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, 100, 100);
            textBox1.Text = ("55555555555555555555");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
            textBox1.Text = ("111111111111111111");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++ )
            {
                this.BackColor  = Color.FromArgb(i, 255, 255);
                textBox1.Text = ("當機了喔");
                Thread.Sleep(10);
            }
        }
    }
}
