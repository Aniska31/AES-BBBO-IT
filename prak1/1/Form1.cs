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
    public Form1()
    {
      InitializeComponent();
      button2.BackColor = Color.White;
      button1.BackColor = Color.White;
      button3.BackColor = Color.White;
      button4.BackColor = Color.White;

    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (button1.BackColor == Color.White)
        button1.BackColor = Color.Red;
      else
        button1.BackColor = Color.White;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (button2.BackColor == Color.White)
        button2.BackColor = Color.Green;
      else
        button2.BackColor = Color.White;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (button3.BackColor == Color.White)
        button3.BackColor = Color.Blue;
      else
        button3.BackColor = Color.White; ;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (button4.BackColor == Color.White)
        button4.BackColor = Color.Yellow;
      else
        button4.BackColor = Color.White;
    }
  }
}
