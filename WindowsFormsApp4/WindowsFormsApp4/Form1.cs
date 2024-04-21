using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(number1.Text);
            double num2 = double.Parse(number2.Text);
            double num3 = double.Parse(number3.Text);
            double sum = num1 + num2 + num3;
            Sum.Text = sum.ToString();
        }
        
    }
}
