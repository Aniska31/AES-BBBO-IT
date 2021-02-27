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

    private void timer1_Tick(object sender, EventArgs e)
    {
      float px = (float)189 / (float)479 * Width;//189- кнопка , 479 сама форма
      int pa = (int)px;
      pictureBox1.Width = pa;
      float py = (float)96 / (float)450 * Height; // 96 - кнопка, 450 сама форма
      int pb = (int)py;
      pictureBox1.Height = pb;
      pictureBox1.Left = (Width-pa)/2;

      /*float lx = (float)110 / (float)479 * Width;
      int la = (int)lx;
      label1.Width = la;
      float ly = (float)13 / (float)450 * Height;
      int lb = (int)ly;
      label1.Height = lb;*/ //для лейбла не работает такая схема
      label1.Top = 150+(pb - 96);//увеличение на разницу между будущей и стандартной фотографией

      float t1x = (float)100 / (float)479 * Width;
      int t1a = (int)t1x;
      textBox1.Width = t1a;
      float t1y = (float)20 / (float)450 * Height;
      int t1b = (int)t1y;
      textBox1.Height = t1b;
      textBox1.Top = 147 + (pb - 96);
      textBox1.Left = (Width - t1a) / 2;
      label1.Left = (Width - t1a) / 2-110;

      float t2x = (float)452 / (float)479* Width;
      int t2a = (int)t2x;
      textBox2.Width = t2a;
      float t2y = (float)196 / (float)450 * Height;
      int t2b = (int)t2y;
      textBox2.Height = t2b;
      textBox2.Top = 173 + (pb - 96);
      textBox2.Left = (Width - t2a) / 2;

      float bx = (float)139 / (float)479 * Width;
      int ba = (int)bx;
      button1.Width = ba;
      float by = (float)34 / (float)450 * Height;
      int bb = (int)by;
      button1.Height = bb;
      button1.Top= 380+ (t2b - 196) + (pb - 96);
      button1.Left = (Width - ba) / 2;

    }
  }
}
