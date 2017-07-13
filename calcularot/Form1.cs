using System;
using System.Net.Mime;
using System.Windows.Forms;
using calcularot.OneArgument;
using calcularot.TwoArguments;

namespace calcularot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListenerTwoArgumentFunction(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                double secondArgument = Convert.ToDouble(textBox2.Text);
                ITwoArgumentsCalculation calculator = TwoArgumentFactory.CreatCalculation(((Button) sender).Name);
                var result = calculator.Calculate(firstArgument, secondArgument);
                textBox4.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Что-то пошло не так" + exc);
            }
        }

        private void ListenerOneArgumentsFunction(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = Convert.ToDouble(textBox1.Text);
                IOneArgumentsCalculation calculator = OneArgumentFactory.CreatCalculation(((Button) sender).Name);
                var result = calculator.Calculate(firstArgument);
                textBox4.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Что-то пошло не так" + exc);
            }
        }
    }
}
