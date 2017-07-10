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
                double FirstArgumeng = Convert.ToDouble(textBox1.Text);
                double SecondArgument = Convert.ToDouble(textBox1.Text);
                double Result = 0;
                switch (((Button)sender).Name)
                {
                    case "button1":
                        { 
                            Result = FirstArgumeng + SecondArgument;
                            textBox3.Text = "+";
                        }
                        break;
                    case "button2":
                        {
                            Result = FirstArgumeng - SecondArgument;
                            textBox3.Text = "-";
                        }
                        break;
                    case "button3":
                        {
                            Result = FirstArgumeng * SecondArgument;
                            textBox3.Text = "*";
                        }
                        break;
                    case "button4":
                        {
                            Result = FirstArgumeng / SecondArgument;
                            textBox3.Text = "/";
                        }
                        break;
                    default:
                        break;
                }
                textBox4.Text = Convert.ToString(Result);
            }
            catch (Exception)
            {
                textBox4.Text = "что-то пошло не так";
            }
        }
    }
}
