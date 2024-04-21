using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double userAge = double.Parse(Age.Text);
            
            if (userAge >= 18)
            {
                label2.Text = "You can drive";
                label2.ForeColor = Color.Green;
            }
            else 
            {
                label2.Text = "You can't drive";
                label2.ForeColor = Color.Red;
            }
        }

        private void canYouDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double userAge = double.Parse(Age.Text);

            if (userAge >= 18)
            {
                label2.Text = "You can drive";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = "You can't drive";
                label2.ForeColor = Color.Red;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Age.Text = "";
            
            label2.Text = "";
            label2.ForeColor = Color.Black;
        }
    }
}
