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
    int[,] Mas = new int[7, 6];
    int[] Max = new int[7];
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Random rand = new Random();
      for (int i = 0; i < 7; i++)
      {
        for (int j = 0; j < 6; j++)
        {
          Mas[i, j] = rand.Next(-100, 100);
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(Mas[i, j]);
        }
        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.White;
        dataGridView1.Rows[i].Cells[6].Value = "";
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < 7; i++)
      {
        Max[i] =101;
        for (int j = 0; j < 6; j++)
        {
          if (Mas[i, j] < Max[i]&&(Mas[i, j]>0))
            Max[i] = Mas[i, j];
        }
        dataGridView1.Rows[i].Cells[6].Style.BackColor = Color.Green;
        dataGridView1.Rows[i].Cells[6].Value = Convert.ToString(Max[i]);
      }
         

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      dataGridView1.RowCount = 7;
      dataGridView1.ColumnCount = 7;
    }
  }
}
