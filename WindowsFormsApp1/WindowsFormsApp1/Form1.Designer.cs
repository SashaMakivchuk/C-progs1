namespace WindowsFormsApp1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rowsNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnNumber = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumber)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(524, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // rowsNumber
            // 
            this.rowsNumber.Location = new System.Drawing.Point(175, 33);
            this.rowsNumber.Name = "rowsNumber";
            this.rowsNumber.Size = new System.Drawing.Size(102, 20);
            this.rowsNumber.TabIndex = 1;
            this.rowsNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rowsNumber.ValueChanged += new System.EventHandler(this.rowNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "cols";
            // 
            // columnNumber
            // 
            this.columnNumber.Location = new System.Drawing.Point(175, 69);
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.Size = new System.Drawing.Size(102, 20);
            this.columnNumber.TabIndex = 3;
            this.columnNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.columnNumber.ValueChanged += new System.EventHandler(this.columnNumber_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.inputToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumToolStripMenuItem,
            this.maxToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operationsToolStripMenuItem.Text = "operations";
            // 
            // sumToolStripMenuItem
            // 
            this.sumToolStripMenuItem.Name = "sumToolStripMenuItem";
            this.sumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumToolStripMenuItem.Text = "sum";
            this.sumToolStripMenuItem.Click += new System.EventHandler(this.sumToolStripMenuItem_Click);
            // 
            // maxToolStripMenuItem
            // 
            this.maxToolStripMenuItem.Name = "maxToolStripMenuItem";
            this.maxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maxToolStripMenuItem.Text = "max";
            this.maxToolStripMenuItem.Click += new System.EventHandler(this.maxToolStripMenuItem_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.inputToolStripMenuItem.Text = "input";
            // 
            // randToolStripMenuItem
            // 
            this.randToolStripMenuItem.Name = "randToolStripMenuItem";
            this.randToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.randToolStripMenuItem.Text = "rand";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.DoubleClick += new System.EventHandler(this.closeToolStripMenuItem_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.columnNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowsNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumber)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown rowsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown columnNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

