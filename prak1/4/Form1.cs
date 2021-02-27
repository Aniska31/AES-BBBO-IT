using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
  public partial class Form1 : Form
  {
    double x;
    double y;
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
          x = double.Parse(textBox1.Text);
          y = Math.Abs(3 + Math.Log(x) + 15 - x) / (1 + Math.Sin((2 + x * x) / (1 + x)));
          textBox2.Text += Environment.NewLine + $"Вы ввели: {x}";
          textBox2.Text += Environment.NewLine + $"Вы получили: {y}";

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox2.Text= "Практическая работа №1 Анисимов Е.С.";
      textBox2.Text += Environment.NewLine + "Рассчитать значение выражения, приведенное выше";
    }
  }
}
