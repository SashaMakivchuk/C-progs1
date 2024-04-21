namespace WindowsFormsApp4
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
            this.number1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.number3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(99, 67);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(100, 20);
            this.number1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "num1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "num2";
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(99, 107);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(100, 20);
            this.number2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "sum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(29, 221);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(193, 20);
            this.Sum.TabIndex = 5;
            this.Sum.TextChanged += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(26, 145);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(33, 13);
            this.num1.TabIndex = 7;
            this.num1.Text = "num3";
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(99, 142);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(100, 20);
            this.number3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.number3);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.TextBox number3;
    }
}

