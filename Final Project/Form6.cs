using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            lbl_Over.Visible = false;

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        bool up, down;
        int distance;

        void trip_result()
        {
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag == "Pilar")

                {
                    foreach (Control j in this.Controls)
                    {

                        if (j is PictureBox && j.Tag == "Enemy")

                        {
                            if (Pilot.Bounds.IntersectsWith(x.Bounds) || Pilot.Bounds.IntersectsWith(j.Bounds))
                            {
                                lbl_Over.Visible = true;
                                timer1.Stop();
                            }
                        }
                    }
                }
            }
        }
        void Enemy_move()
        {
            Random rnd = new Random();
            int x;
            foreach (Control j in this.Controls)
            {

                if (j is PictureBox && j.Tag == "enemy")

                {
                    j.Left -= 5;
                    if (j.Left < 0)
                    {
                        x = rnd.Next(80, 300);
                        j.Location = new Point(800, x);

                        distance++;
                        lbl_distance.Text = "distance : " + distance;

                    }
                }
            }
        }

        void Pilar_move()
        {
            foreach (Control x in this.Controls)
            {

                if (x is PictureBox && x.Tag=="Pilar")

                {
                    x.Left -= 5;
                    if (x.Left <- 350)
                    {
                        x.Left = 750;
                    }
                }
            }
        }
        

        void Pilot_move()
        {
            if (up == true)
            {
                Pilot.Top -= 5;
            }
            if (down == true)
            {
                Pilot.Top += 5;
            }

        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    up = true;

                    break;
                case Keys.Down:

                    down = true;

                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pilot_move();

            Pilar_move();

            Enemy_move();

            trip_result();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:

                    up = false;

                    break;
                case Keys.Down:

                    down = false;

                    break;
            }
        }
    }
}
