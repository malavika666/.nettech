using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                App.PhoneBook.AddPhoneBookRow(App.PhoneBook.NewPhoneBookRow());
                phoneBookBindingSource.MoveLast();
                textBox3.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneBook.RejectChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtPhone.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            phonebookBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
