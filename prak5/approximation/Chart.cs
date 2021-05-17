using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace it_lab_12
{
  public partial class Chart : Form
  {
    public static List<Tuple<double, double>> points = Form1.points;
    public static List<double> X = new List<double>();
    public static int count;//кол во добавленных итераций, 1итерация=1слева и 1 справа
    public static double y_zoom_min, y_zoom_max;
    public Chart()
    {
      InitializeComponent();
      count = 0;
      chart1.Series.Clear();//очищение графика
      chart1.ChartAreas.Clear();
      chart1.Legends.Clear();
      double[] x = points.Select(_ => _.Item1).ToArray();
      double[] y = points.Select(_ => _.Item2).ToArray();
      double Xmin = x.Min();
      double Xmax = x.Max();
      double Ymin = y.Min()-1;
      double Ymax = y.Max()+1;
      double step_x = 0.2;
      double step_y = 1;
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = Xmin;
      area.AxisX.Maximum = Xmax;
      area.AxisX.MajorGrid.Interval = step_x;
      area.AxisY.Minimum = Ymin;
      area.AxisY.Maximum = Ymax;
      area.AxisY.MajorGrid.Interval = step_y;
      chart1.ChartAreas.Add(area);
      Chart_points();
      first();
      second();
    }
    private void Chart_points()
    {
      double[] x = points.Select(_ => _.Item1).ToArray();
      double[] y = points.Select(_ => _.Item2).ToArray();
      Series series_0 = new Series();
      series_0.ChartArea = "myGraph";
      series_0.ChartType = SeriesChartType.Point;
      series_0.MarkerSize = 10;
      series_0.LegendText = "Начальные точки";
      chart1.Series.Add(series_0);
      Legend legend = new Legend();
      chart1.Legends.Add(legend);
      chart1.Series[0].Points.DataBindXY(x, y);
    }
    private void first()
    {
      X.Clear();
      double[] x = points.Select(_ => _.Item1).ToArray();
      for (int i = 0; i < x.Length; i++)
        X.Add(x[i]);
      for(int i=0;i<count;i++)
      {
        X.Add(X.Min()-0.2);
        X.Add(X.Max() + 0.2);
      }
      X.Sort();
      double[] y_1 = LinearRegression.CalculateY_zoom(1);
      y_zoom_max = y_1[0];
      ChartArea area = new ChartArea();
      Series series_1 = new Series();
      series_1.ChartArea = "myGraph";
      series_1.ChartType = SeriesChartType.Spline;
      series_1.BorderWidth = 3;
      series_1.LegendText = "Полином I степени";
      chart1.Series.Add(series_1);
      chart1.Series[1].Points.DataBindXY(X, y_1);
    }
    private void second()
    {
      X.Clear();
      double[] x = points.Select(_ => _.Item1).ToArray();
      for (int i = 0; i < x.Length; i++)
        X.Add(x[i]);
      for (int i = 0; i < count; i++)
      {
        X.Add(X.Min() - 0.2);
        X.Add(X.Max() + 0.2);
      }
      X.Sort();
      double[] y_2 = LinearRegression.CalculateY_zoom(2);
      y_zoom_min = y_2[y_2.Length-1];
      Series series_2 = new Series();
      series_2.ChartArea = "myGraph";
      series_2.ChartType = SeriesChartType.Spline;
      series_2.BorderWidth = 3;
      series_2.LegendText = "Полином II степени";
      chart1.Series.Add(series_2);
      chart1.Series[2].Points.DataBindXY(X, y_2);
    }
    private void button2_Click(object sender, EventArgs e)
    {

      count--;
      if(count<=0)
      {
        MessageBox.Show("Вы достигли минимума. Дальнейшее уменьшение итераций приведет к уничтожению точек!");
        count = 0;
      }

      chart1.Series.Clear();//очищение графика
      chart1.ChartAreas.Clear();
      chart1.Legends.Clear();
      double[] x = points.Select(_ => _.Item1).ToArray();
      double[] y = points.Select(_ => _.Item2).ToArray();
      double Xmin = x.Min();
      double Xmax = x.Max();
      double Ymin = y.Min()-1;
      double Ymax = y.Max()+1;
      double step_x = 0.2;
      double step_y = 1;
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = Xmin - step_x * count;
      area.AxisX.Maximum = Xmax + step_x * count;
      area.AxisX.MajorGrid.Interval = step_x;
      area.AxisY.Minimum = Ymin;
      area.AxisY.Maximum = Ymax;
      area.AxisY.MajorGrid.Interval = step_y;
      chart1.ChartAreas.Add(area);

      Chart_points();
      first();
      second();

      if (y_zoom_max < Ymax)
        area.AxisY.Maximum = Ymax;
      else
        area.AxisY.Maximum = y_zoom_max + 1;
      if (y_zoom_min < Ymin)
        area.AxisY.Minimum = y_zoom_min - 1;
      else
        area.AxisY.Minimum = Ymin;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      count++;

      chart1.Series.Clear();//очищение графика
      chart1.ChartAreas.Clear();
      chart1.Legends.Clear();
      double[] x = points.Select(_ => _.Item1).ToArray();
      double[] y = points.Select(_ => _.Item2).ToArray();
      double Xmin = x.Min();
      double Xmax = x.Max();
      double Ymin = y.Min()-1;
      double Ymax = y.Max()+1;
      double step_x = 0.2;
      double step_y = 1;
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = Xmin- step_x*count;
      area.AxisX.Maximum = Xmax+ step_x * count;
      area.AxisX.MajorGrid.Interval = step_x;
      area.AxisY.Minimum = Ymin;
      area.AxisY.Maximum = Ymax;
      area.AxisY.MajorGrid.Interval = step_y;
      chart1.ChartAreas.Add(area);

      Chart_points();
      first();
      second();

      if (y_zoom_max < Ymax)
        area.AxisY.Maximum = Ymax;
      else
        area.AxisY.Maximum = y_zoom_max + 1;
      if (y_zoom_min < Ymin)
        area.AxisY.Minimum = y_zoom_min - 1;
      else
        area.AxisY.Minimum = Ymin;
    }
  }
}
