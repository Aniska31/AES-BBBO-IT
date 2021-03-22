namespace _1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(98, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(612, 31);
      this.label1.TabIndex = 0;
      this.label1.Text = "7.  Заменить отрицательные элементы нулями.";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 83);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(141, 332);
      this.textBox1.TabIndex = 1;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(189, 83);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.textBox2.Size = new System.Drawing.Size(583, 332);
      this.textBox2.TabIndex = 2;
      // 
      // button1
      // 
      this.button1.AutoSize = true;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button1.Location = new System.Drawing.Point(12, 421);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(131, 36);
      this.button1.TabIndex = 3;
      this.button1.Text = "Заполнить";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.AutoSize = true;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button2.Location = new System.Drawing.Point(461, 421);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(139, 36);
      this.button2.TabIndex = 4;
      this.button2.Text = "Рассчитать";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label2.Location = new System.Drawing.Point(12, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(171, 24);
      this.label2.TabIndex = 5;
      this.label2.Text = "Исходный массив";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label3.Location = new System.Drawing.Point(232, 56);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(246, 24);
      this.label3.TabIndex = 6;
      this.label3.Text = "Преобразованный массив";
      // 
      // button3
      // 
      this.button3.AutoSize = true;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.button3.Location = new System.Drawing.Point(265, 507);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(131, 36);
      this.button3.TabIndex = 7;
      this.button3.Text = "Ввести";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(286, 469);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 32);
      this.textBox3.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(319, 453);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "label4";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(784, 561);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
    }
}

