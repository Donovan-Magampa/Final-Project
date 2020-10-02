using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }
    }
}
