using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void btn_Database_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void btn_Camp_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void btn_Map_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void btn_Simulation_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

        }
    }
}
