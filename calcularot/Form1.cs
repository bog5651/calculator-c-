﻿using System;
using System.Windows.Forms;
using calcularot.OneArgumentClass;
using calcularot.TwoArgumentClass;

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
            ITwoArgumentsCalculation calculator = TwoArgumentFactory.CreatCalculation(((Button)sender).Name);
            var result = calculator.Calculate(firstArgument, secondArgument);
            textBox4.Text = result.ToString();
        }

        private void ListenerOneArgumentsFunction(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(textBox1.Text);
            IOneArgumentsCalculation calculator = OneArgumentFactory.CreatCalculation(((Button)sender).Name);
            var result = calculator.Calculate(firstArgument);
            textBox4.Text = result.ToString();
        }
    }
}
