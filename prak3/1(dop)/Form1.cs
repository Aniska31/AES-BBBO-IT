using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
  public partial class Form1 : Form
  {
    int[] current;
    int[] edit;
    int count;

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      current = new int[count];
        Random rand = new Random();
        textBox1.Text = "";
        for (int i = 0; i < count; i++)
        {
          current[i] = rand.Next(-50, 50);
          textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(current[i]) + Environment.NewLine;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      edit = new int[count];
      textBox2.Text = "";
      int sqrt = (int)Math.Sqrt(count);
      int check = 0;
      for (int b = 0; b <= sqrt; b++)//проверка на квадрат
        if (b * b == count)
          check = 1;
      for (int i = 0; i < count; i++)//выполнение задания
        if (current[i] < 0)
          edit[i] = 0;
        else
          edit[i] = current[i];
      if (check==0) //не квадрат
        for (int i = 0; i < count; i++)
          textBox2.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(edit[i]) + Environment.NewLine;
      else//квадрат
      {
        int pos = 0;
        for (int i = 0; i < sqrt; i++)
        {
          for (int j = 0; j < sqrt; j++)
          {
            textBox2.Text += "Mas[" + Convert.ToString(i) + "," + Convert.ToString(j) + "] = " + Convert.ToString(edit[pos]) + "  ";
            pos++;
          }
          textBox2.Text += Environment.NewLine;
        }
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (Int32.TryParse(textBox3.Text, out count))
        count = Int32.Parse(textBox3.Text);
      else
      {
        MessageBox.Show("Вы не ввели число.Повторите снова.");
        return;
      }
      label4.Text = textBox3.Text;
      textBox3.Text = "";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label4.Text = "";
    }
  }
}
