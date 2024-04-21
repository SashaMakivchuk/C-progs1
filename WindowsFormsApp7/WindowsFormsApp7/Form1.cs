using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void affordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double userCost = double.Parse(cost.Text);
            double userMoney = double.Parse(money.Text);
            if(userCost <= userMoney)
            {
                label3.Text = "You can drive";
                label3.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "You can't drive";
                label3.ForeColor = Color.Red;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost.Text = "";
            money.Text = "";
            label3.Text = "";
            label3.ForeColor = Color.Black;
        }

        private void cost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
