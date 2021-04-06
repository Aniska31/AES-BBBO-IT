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
    public Form1()
    {
      InitializeComponent();
    }


    int change_1= 0;
    int change_2 = 0;
    int color = 0;
    Random rnd = new Random();
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics; // Объявляется объект Graphics. Далее вставляется код рисования
        Pen pen;
        if (color%2==0)
        {
          g.Clear(Color.DeepSkyBlue);
          pen = new Pen(Brushes.Black);
        }
        else
        {
          g.Clear(Color.Black);
          pen = new Pen(Brushes.DeepSkyBlue);
         }
        Graphics circle_main = this.CreateGraphics();
        Graphics circle_left = this.CreateGraphics();
        Graphics circle_right = this.CreateGraphics();
        Graphics trinagle_up = this.CreateGraphics();
        Graphics trinagle_left = this.CreateGraphics();
        Graphics trinagle_right = this.CreateGraphics();
        Graphics cross_left = this.CreateGraphics();
        Graphics cross_right = this.CreateGraphics();
        circle_main.DrawEllipse(pen, 350 + change_1, 250 + change_2, 70, 70);//нос
        circle_left.DrawEllipse(pen, 280 + change_1, 300 + change_2, 35, 35);//пропеллер левый
        circle_right.DrawEllipse(pen, 450 + change_1, 300 + change_2, 35, 35);//пропеллер правый
        Point[] points = new Point[3];
        points[0].X = 150 + change_1; points[0].Y = 285 + change_2;
        points[1].X = 355 + change_1; points[1].Y = 265 + change_2;
        points[2].X = 355 + change_1; points[2].Y = 305 + change_2;
        trinagle_left.DrawPolygon(pen, points);//левое крыло
        points[0].X = 415 + change_1; points[0].Y = 305 + change_2;
        points[1].X = 415 + change_1; points[1].Y = 265 + change_2;
        points[2].X = 620 + change_1; points[2].Y = 285 + change_2;
        trinagle_right.DrawPolygon(pen, points);//правое крыло
        points[0].X = 335 + change_1; points[0].Y = 250 + change_2;
        points[1].X = 435 + change_1; points[1].Y = 250 + change_2;
        points[2].X = 385 + change_1; points[2].Y = 200 + change_2;
        trinagle_up.DrawPolygon(pen, points);//вверх
        cross_left.DrawLine(pen, 280 + change_1, 300 + change_2, 315 + change_1, 335 + change_2);// крест левый1
        cross_left.DrawLine(pen, 280 + change_1, 335 + change_2, 315 + change_1, 300 + change_2); // крест левый2
        cross_right.DrawLine(pen, 450 + change_1, 300 + change_2, 485 + change_1, 335 + change_2);// крест правый1
        cross_right.DrawLine(pen, 450 + change_1, 335 + change_2, 485 + change_1, 300 + change_2);// крест правый1
    }

    private void button1_Click(object sender, EventArgs e)
    {
      change_1 = rnd.Next(-100, 100);
      change_2 = rnd.Next(-100, 100);
      color++;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      change_1 = rnd.Next(-100, 100);
      change_2 = rnd.Next(-100, 100);
      color++;
    }
  }
}
