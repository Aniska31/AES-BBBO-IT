using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
  public partial class Form1 : Form
  {
    static int Factorial(int x)
    {
      if (x == 0)
      {
        return 1;
      }
      else
      {
        return x * Factorial(x - 1);
      }
    }

    public double Sum_elem(int x) { return 2.0 / Math.Sqrt(Factorial(x) + 4); }
    public double Comp_elem(int x) { return 1.0/ Math.Sqrt(Factorial(3 * x + 1)); }
    public Form1()
    {
      InitializeComponent();
      textBox2.Text += "Результаты работы программы Анисимова Е.С.";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double function;
      double accuracy;
      string row;
      if (Double.TryParse(textBox1.Text, out accuracy))
      {
        accuracy = Double.Parse(textBox1.Text);
        if (accuracy <= 0)
        { 
           MessageBox.Show("Вы ввели отрицательную точность или нулевую. Введите заново.");
          return;
        }
      }
      else
      {
        MessageBox.Show("Вы ввели не число.Повторите еще раз");
        return;
      }
      if (radioButton1.Checked)
      {
        int n = 1;
        function = Sum_elem(n);
        while (Sum_elem(n)>accuracy)
        {
          n++;
          function += Sum_elem(n);
        }
        row = " суммы ряда: ";
      }
      else
      {
        int n = 0;
        function = Comp_elem(n);
        while (Comp_elem(n)> accuracy)
        {
          n++;
          function *= Comp_elem(n);
        }
        row = " произведения ряда: ";
      }
      textBox2.Text += Environment.NewLine + "Расчет" + row + function;
    }
  }
}
