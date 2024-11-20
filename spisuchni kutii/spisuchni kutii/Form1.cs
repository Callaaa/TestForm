using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spisuchni_kutii
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double chislo = double.Parse(textBox1.Text);
            double chislo2 = double.Parse(textBox2.Text);
            double sum = chislo + chislo2;
            if (chislo > chislo2)
            {
                listBox1.Items.Add(chislo);
            }
            if (chislo2 > chislo)
            {
                listBox1.Items.Add(chislo2);
            }
            listBox2.Items.Add(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double[] masiv = listBox1.Items.Cast<double>().ToArray();
            double min = masiv.Min();
            MessageBox.Show("nai-maslkoto chislo: " + min);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
