namespace calcularot
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiplire = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sin = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.ex = new System.Windows.Forms.Button();
            this.Log2 = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.x2 = new System.Windows.Forms.Button();
            this.x10 = new System.Windows.Forms.Button();
            this.x1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(21, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(0, 155);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(35, 23);
            this.Plus.TabIndex = 3;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Listner);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(41, 155);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(38, 23);
            this.Minus.TabIndex = 4;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Listner);
            // 
            // Multiplire
            // 
            this.Multiplire.Location = new System.Drawing.Point(85, 155);
            this.Multiplire.Name = "Multiplire";
            this.Multiplire.Size = new System.Drawing.Size(37, 23);
            this.Multiplire.TabIndex = 5;
            this.Multiplire.Text = "*";
            this.Multiplire.UseVisualStyleBackColor = true;
            this.Multiplire.Click += new System.EventHandler(this.Listner);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(128, 155);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(43, 23);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.Listner);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "B";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(172, 115);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "=";
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(178, 155);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(35, 23);
            this.sin.TabIndex = 12;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(219, 155);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(38, 23);
            this.cos.TabIndex = 13;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(0, 185);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(35, 23);
            this.tan.TabIndex = 14;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(42, 185);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(37, 23);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // ex
            // 
            this.ex.Location = new System.Drawing.Point(86, 185);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(36, 23);
            this.ex.TabIndex = 16;
            this.ex.Text = "e^x";
            this.ex.UseVisualStyleBackColor = true;
            this.ex.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // Log2
            // 
            this.Log2.Location = new System.Drawing.Point(129, 185);
            this.Log2.Name = "Log2";
            this.Log2.Size = new System.Drawing.Size(42, 23);
            this.Log2.TabIndex = 17;
            this.Log2.Text = "Log2";
            this.Log2.UseVisualStyleBackColor = true;
            this.Log2.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // Log10
            // 
            this.Log10.Location = new System.Drawing.Point(178, 185);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(45, 23);
            this.Log10.TabIndex = 18;
            this.Log10.Text = "Log10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(229, 185);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(38, 23);
            this.x2.TabIndex = 19;
            this.x2.Text = "x^2";
            this.x2.UseVisualStyleBackColor = true;
            this.x2.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // x10
            // 
            this.x10.Location = new System.Drawing.Point(0, 215);
            this.x10.Name = "x10";
            this.x10.Size = new System.Drawing.Size(44, 23);
            this.x10.TabIndex = 20;
            this.x10.Text = "10^x";
            this.x10.UseVisualStyleBackColor = true;
            this.x10.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(50, 214);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(40, 23);
            this.x1.TabIndex = 21;
            this.x1.Text = "1/x";
            this.x1.UseVisualStyleBackColor = true;
            this.x1.Click += new System.EventHandler(this.ListnerOneArgumentsFunction);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.x10);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Log2);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.cos);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplire);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiplire;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button ex;
        private System.Windows.Forms.Button Log2;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button x2;
        private System.Windows.Forms.Button x10;
        private System.Windows.Forms.Button x1;
    }
}

