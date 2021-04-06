using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _1
{
  public partial class Form1 : Form
  {
    Chart chart;
    private double XMin = 0.1;
    private double XMax = 9;
    private double Step = 0.1;
    private double[] x;
    private double[] y;
    //private double[] y2;

    private void CalcFunction()
    {
      // Количество точек графика
      int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
      // Создаём массивы нужных размеров
      x = new double[count];
      y = new double[count];
      //y2 = new double[count];
      // Расчитываем точки для графиков функции
      for (int i = 0; i < count; i++)
      {
        // Вычисляем значение X
        x[i] = XMin + Step * i;
        // Вычисляем значение функций в точке X
        y[i] = (Math.Sqrt(3 + Math.Log(x[i]) + 15 - x[i])) / (1 + Math.Sin((2 + x[i] * x[i]) / (1 + x[i])));
        //y2[i] = Math.Cos(x[i]);
      }
    }
    private void CreateChart()
    {
      // Создаёмновыйэлементуправления Chart
      chart = new Chart();
      // Помещаем его на форму
      chart.Parent = this;
      // Задаём размеры элемента
      chart.SetBounds(10, 10, ClientSize.Width - 20,
      ClientSize.Height - 20);
      // Создаём новую область для построения графика
      ChartArea area = new ChartArea();
      // Даём ей имя (чтобы потом добавлять графики)
      area.Name = "myGraph";
      // Задаём левую и правую границы оси X
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;
      // Определяемшагсетки
      area.AxisX.MajorGrid.Interval = Step;
      // Добавляем область в диаграмму
      chart.ChartAreas.Add(area);

      // Создаём объект для первого графика
      Series series1 = new Series();
      // Ссылаемся на область для построения графика
      series1.ChartArea = "myGraph";
      // Задаём тип графика - сплайны
      series1.ChartType = SeriesChartType.Spline;
      // Указываем ширину линии графика
      series1.BorderWidth = 3;
      // Название графика для отображения в легенде
      series1.LegendText = "11 вариант";
      // Добавляем в список графиков диаграммы
      chart.Series.Add(series1);
     /* // Аналогичные действия для второго графика
      Series series2 = new Series();
      series2.ChartArea = "myGraph";
      series2.ChartType = SeriesChartType.Spline;
      series2.BorderWidth = 3;
      series2.LegendText = "cos(x)";
      chart.Series.Add(series2);*/

      // Создаёмлегенду, котораябудетпоказыватьназвания
      Legend legend = new Legend();
      chart.Legends.Add(legend);
    }

  public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // Создаём элемент управления
      CreateChart();
      // Расчитываем значения точек графиков функций
      CalcFunction();
      // Добавляем вычисленные значения в графики
      chart.Series[0].Points.DataBindXY(x, y);
      //chart.Series[1].Points.DataBindXY(x, y2);
    }
  }
}
