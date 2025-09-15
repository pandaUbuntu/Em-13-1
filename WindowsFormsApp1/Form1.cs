using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            
            if (text.Trim().Length > 0 )
            {
                MessageBox.Show(text, "Ось ваш текст", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ви не ввели текст!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            textBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstNumber, secondNumber;
            try
            {
                if (textBox2.Text.Trim().Length > 0 && textBox3.Text.Trim().Length > 0)
                {
                    firstNumber = Convert.ToDouble(textBox2.Text.Trim());
                    secondNumber = Convert.ToDouble(textBox3.Text.Trim());
                }
                else
                {
                    throw new Exception("Помилка! Ви не ввели числа.");
                }

                if (secondNumber != 0)
                {
                    label4.Text = ($"Результат: {Math.Round((firstNumber/secondNumber), 2)}");
                }
                else
                {
                    throw new Exception("Помилка! Не можна ділити на нуль.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка! Ви ввели дані не в тому форматі.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            count = 0;
            label5.Text = "0 - натискай нижче!";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            count += 1;
            label5.Text = ($"Кліків: {Convert.ToString(count)}");
        }
    }
}
