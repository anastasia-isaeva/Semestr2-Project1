using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semestr_Project
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            textBox1.Text = @"tut byl vasya
and petya";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text += "\r\nSosi pipisku";
        }
    }
}
