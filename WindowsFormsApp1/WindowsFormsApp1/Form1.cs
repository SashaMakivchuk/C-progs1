using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)rowsNumber.Value;
            dataGridView1.ColumnCount = (int)columnNumber.Value;
        }

        private void rowNumber_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)rowsNumber.Value;
        }

        private void columnNumber_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount=(int)columnNumber.Value;
        }

        private void closeToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void sumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sum = MatrixOperations.getSum(dataGridView1);
            MessageBox.Show($"sum = {sum}");
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
