using System;
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
            double firstArgumeng = Convert.ToDouble(textBox1.Text);
            double secondArgument = Convert.ToDouble(textBox2.Text);
            ITwoArgumentsCalculation calculator = TwoArgumentFactory.CreatCalculation(((Button) sender).Name);
            var result = calculator.Calculate(firstArgumeng, secondArgument);
            textBox4.Text = result.ToString();
        }

        private void ListnerOneArgumentsFunction(object sender, EventArgs e)
        {
            double firstArgumeng = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculation calculator = OneArgumentFactory.CreatCalculation(((Button)sender).Name);
            var result = calculator.Calculate(firstArgumeng);
            textBox4.Text = result.ToString();
        }
    }
}
