using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Task
{
    public partial class Form1 : Form
    {
        private Operation operation = Operation.addition;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Welcome_Text_Box.Text = "Witaj " + Name_Box.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;

            if (Int32.TryParse(First_Number.Text, out firstNumber) && Int32.TryParse(Second_Number.Text, out secondNumber))
            {
                Result.Text = ChooseOperation(firstNumber, secondNumber).ToString();
            }
            else
                Result.Text = "Podaj poprawne liczby typu Integer";
        }

        private void Add_Radio_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.addition;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.substraction;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.multiplication;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.division;
        }

        private float ChooseOperation(float firstNumber, float secondNumber)
        {
            switch (operation)
            {
                case Operation.addition:
                    return firstNumber + secondNumber;

                case Operation.substraction:
                    return firstNumber - secondNumber;

                case Operation.multiplication:
                    return firstNumber * secondNumber;

                case Operation.division:
                    return firstNumber / secondNumber;

                default:
                    return 0;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            Point point = new Point();
            point.X = random.Next(Runner.Parent.Width - Runner.Width);
            point.Y = random.Next(Runner.Parent.Height - Runner.Height);
            Runner.Location = point;
        }
    }

    internal enum Operation
    {
        addition,
        substraction,
        multiplication,
        division
    }
}