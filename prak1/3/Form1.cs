using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      textBox1.Enabled = false;
    }

        private void button1_Click(object sender, EventArgs e)
        {
         textBox2.Enabled = false;
        }

    private void button2_Click(object sender, EventArgs e)
    {
      textBox2.Enabled = true;
    }

    private void Form1_Click(object sender, EventArgs e)
    {
      button1.Visible = false;
      button2.Visible = false;
      textBox2.Visible = false;
      textBox2.Enabled = false;
      button1.Enabled = false;
      button2.Enabled = false;
      BackColor = Color.Black;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button1.Visible = true;
      button2.Visible = true;
      textBox2.Visible = true;
      textBox2.Enabled = true;
      button1.Enabled = true;
      button2.Enabled = true;
      BackColor = Color.White;
    }
  }
}
