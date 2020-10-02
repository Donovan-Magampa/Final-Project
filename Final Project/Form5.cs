using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }
    }
}
