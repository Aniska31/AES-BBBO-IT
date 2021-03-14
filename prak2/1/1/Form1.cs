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
    public double Function(string _func_name,double _X)
    {
      if (_func_name == "Sh") return Math.Sinh(_X);
      if (_func_name == "Ch") return Math.Cosh(_X);
      else return Math.Exp(_X);
    }
    public  double Solution(string _func_name, double _X)
    {
      if((_X>=0)&&(_X<=3))
          return 2;
      if (_X > 3) return (0.5 * Function(_func_name, _X));
        else
          return (1 / Function(_func_name, _X));
    }
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string func = "";
      if (radioButton1.Checked)
        func = "Sh";
      else
          if ((radioButton2.Checked))
            func = "Ch";
          else
            func = "Exp";
      if (textBox2.Text == "")
        {
        MessageBox.Show("Вы не ввели x.Введите его.");
        return;
        }
      double X = Convert.ToDouble(textBox2.Text);
      textBox4.Text += Environment.NewLine + "При X:" + X + " и F(x):"+func + " Y:" + Solution(func,X);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox4.Text += "Результаты работ программы студента Анисимова Е.С.";
    }
  }
}
