using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitEglut
{
    public partial class Form1 : Form
    {
        public int[] A = new int[10];
        public int n = 0;
        public int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            int x = Convert.ToInt32(richTextBox1.Text);
            richTextBox1.Clear();
            A[n] = x;
            n++;
            if (n == 1)
            {
                richTextBox2.Text = "Įvestas " + n + " skaičius. ";
            }
            else if (n < 10)
            {
                richTextBox2.Text = "Įvesti " + n + " skaičiai. ";
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += A[i];
                }
                richTextBox2.Text = "10 skaičių suma: " + sum;
                sum = 0;
                n = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox4.Clear();
            int y = Convert.ToInt32(richTextBox3.Text);
            richTextBox3.Clear();
            int sluoksniai = y;
            int zvaigzd = 1;
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < sluoksniai; j++)
                {
                    richTextBox4.Text += " ";
                }
                sluoksniai--;
                for (int j = 0; j < zvaigzd; j++)
                {
                    richTextBox4.Text += "* ";
                }
                zvaigzd++;
                richTextBox4.Text += "\n";
            }
        }
    }
}
