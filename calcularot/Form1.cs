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
                double firstArgumeng = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox1.Text);
                double result;
                switch (((Button)sender).Name)
                {
                    case "button1":
                        { 
                            result = firstArgumeng + secondArgument;
                            textBox3.Text = "+";
                        }
                        break;
                    case "button2":
                        {
                            result = firstArgumeng - secondArgument;
                            textBox3.Text = "-";
                        }
                        break;
                    case "button3":
                        {
                            result = firstArgumeng * secondArgument;
                            textBox3.Text = "*";
                        }
                        break;
                    case "button4":
                        {
                            result = firstArgumeng / secondArgument;
                            textBox3.Text = "/";
                        }
                        break;
                    default:
                        throw new Exception("Неизвестная операция");
                }
                textBox4.Text = Convert.ToString(result);
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }
    }
}
