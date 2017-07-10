using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcularot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                double SecondArgument = Convert.ToDouble(textBox1.Text);
                double Result = FirstArgumeng + SecondArgument;
                textBox3.Text = "+";
                textBox4.Text = Convert.ToString(Result);
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                double SecondArgument = Convert.ToDouble(textBox1.Text);
                double Result = FirstArgumeng - SecondArgument;
                textBox3.Text = "-";
                textBox4.Text = Convert.ToString(Result);
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                double SecondArgument = Convert.ToDouble(textBox1.Text);
                double Result = FirstArgumeng * SecondArgument;
                textBox3.Text = "*";
                textBox4.Text = Convert.ToString(Result);
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                double SecondArgument = Convert.ToDouble(textBox1.Text);
                double Result = FirstArgumeng / SecondArgument;
                textBox3.Text = "/";
                textBox4.Text = Convert.ToString(Result);
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }
    }
}
