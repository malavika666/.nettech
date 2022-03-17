using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(txtnum1.Text);
            num2 = Convert.ToInt32(txtnum2.Text);
            sum = num1 + num2;
            lblResult.Text = sum.ToString();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
