﻿using System;
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
    }

    private void button2_Click(object sender, EventArgs e)
    {
      string text = textBox1.Text;
      listBox1.Items.Add(text);
      textBox1.Text = "";
    }

    private void button1_Click_1(object sender, EventArgs e)
    {
      int index = listBox1.SelectedIndex;
      string str = (string)listBox1.Items[index];
      string edit = "";
      edit = str.Replace("а", "б");
      label2.Text = edit;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      label2.Text = "";
    }
  }
}
