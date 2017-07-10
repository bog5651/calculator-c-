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

        private void Listner(object sender, EventArgs e)
        {
            try
            {
                switch (((Button)sender).Name)
                {
                    case "button1":
                        {
                            double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                            double SecondArgument = Convert.ToDouble(textBox1.Text);
                            double Result = FirstArgumeng + SecondArgument;
                            textBox3.Text = "+";
                            textBox4.Text = Convert.ToString(Result);
                        }
                        break;
                    case "button2":
                        {
                            double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                            double SecondArgument = Convert.ToDouble(textBox1.Text);
                            double Result = FirstArgumeng - SecondArgument;
                            textBox3.Text = "-";
                            textBox4.Text = Convert.ToString(Result);
                        }
                        break;
                    case "button3":
                        {
                            double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                            double SecondArgument = Convert.ToDouble(textBox1.Text);
                            double Result = FirstArgumeng * SecondArgument;
                            textBox3.Text = "*";
                            textBox4.Text = Convert.ToString(Result);
                        }
                        break;
                    case "button4":
                        {
                            double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                            double SecondArgument = Convert.ToDouble(textBox1.Text);
                            double Result = FirstArgumeng / SecondArgument;
                            textBox3.Text = "/";
                            textBox4.Text = Convert.ToString(Result);
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }
    }
}
