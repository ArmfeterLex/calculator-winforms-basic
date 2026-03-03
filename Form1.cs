using System;
using System.Windows.Forms;

namespace Project8
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // +
        {
            try
            {
                firstNumber = double.Parse(textBox1.Text);
                operation = "+";
                CalculateResult();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовые значения.", "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e) // -
        {
            try
            {
                firstNumber = double.Parse(textBox1.Text);
                operation = "-";
                CalculateResult();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовые значения.", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e) // *
        {
            try
            {
                firstNumber = double.Parse(textBox1.Text);
                operation = "*";
                CalculateResult();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовые значения.", "Ошибка");
            }
        }

        private void button4_Click(object sender, EventArgs e) // /
        {
            try
            {
                firstNumber = double.Parse(textBox1.Text);
                operation = "/";
                CalculateResult();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовые значения.", "Ошибка");
            }
        }

        private void button5_Click(object sender, EventArgs e) // ^
        {
            try
            {
                firstNumber = double.Parse(textBox1.Text);
                operation = "^";
                CalculateResult();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовые значения.", "Ошибка");
            }
        }

        private void CalculateResult()
        {
            try
            {
                double secondNumber = double.Parse(textBox2.Text);

                switch (operation)
                {
                    case "+":
                        textBox3.Text = (firstNumber + secondNumber).ToString();
                        break;
                    case "-":
                        textBox3.Text = (firstNumber - secondNumber).ToString();
                        break;
                    case "*":
                        textBox3.Text = (firstNumber * secondNumber).ToString();
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            MessageBox.Show("Деление на ноль невозможно!", "Ошибка");
                            textBox3.Text = "";
                        }
                        else
                        {
                            textBox3.Text = (firstNumber / secondNumber).ToString();
                        }
                        break;
                    case "^":
                        textBox3.Text = Math.Pow(firstNumber, secondNumber).ToString();
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод. Пожалуйста, введите числовые значения.", "Ошибка");
            }
        }
    }
}