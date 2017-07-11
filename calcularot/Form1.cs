using System;
using System.Globalization;
using System.Windows.Forms;

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
            double firstArgument = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            ITwoArgumentsCalculation calculator = TwoArgumentFactory.CreatCalculation(((Button) sender).Name);
            var result = calculator.Calculate(firstArgument, secondArgument);
            textBox4.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        private void ListenerOneArgumentsFunction(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculation calculator = OneArgumentFactory.CreatCalculation(((Button)sender).Name);
            var result = calculator.Calculate(firstArgument);
            textBox4.Text = result.ToString(CultureInfo.InvariantCulture);
        }
    }
}
