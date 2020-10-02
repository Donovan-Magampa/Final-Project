using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form3 : Form
    {
        private bool selected;


        public string Pilot_ID { get; private set; }
        public string Pilot_Name { get; private set; }
        public string AirCraft_Name { get; private set; }
        public string AirCraft_Model { get; private set; }
        public string Status { get; private set; }
        public Form3()
        {
            InitializeComponent();
        }

        //Move Back to the previous form of action
        private void button4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        //Move to the next form of action
        private void button5_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Pilot_ID", 150);
            listView1.Columns.Add("Pilot_Name", 150);
            listView1.Columns.Add("AirCraft_Name", 150);
            listView1.Columns.Add("AirCraft_Model", 250);
            listView1.Columns.Add("Status", 150);
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                Pilot_ID = listView1.SelectedItems[0].SubItems[1].Text;
                Pilot_Name = listView1.SelectedItems[0].SubItems[1].Text;
                AirCraft_Name = listView1.SelectedItems[0].SubItems[1].Text;
                AirCraft_Model = listView1.SelectedItems[0].SubItems[1].Text;
                Status = listView1.SelectedItems[0].SubItems[1].Text;

                selected = true;
            }
            else
            {
                selected = false;
            }
        }

        //Add new Item\s
        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new[] { Pilot_ID, Pilot_Name, AirCraft_Name, AirCraft_Model, Status }));

            //Clear Texts
            clearTxts();
        }

        //Update ListView Item\s
        private void button2_Click(object sender, EventArgs e)
        {
            update();
        }
        private void update()
        {
            listView1.SelectedItems[0].SubItems[1].Text = Pilot_ID;
            listView1.SelectedItems[0].SubItems[1].Text = Pilot_Name;
            listView1.SelectedItems[0].SubItems[1].Text = AirCraft_Name;
            listView1.SelectedItems[0].SubItems[1].Text = AirCraft_Model;
            listView1.SelectedItems[0].SubItems[1].Text = Status;

            //Clear Texts
            clearTxts();
        }

        //Delete ListView Item\s
        private void button3_Click(object sender, EventArgs e)
        {
            delete();
        }
        private void delete()
        {
            if (MessageBox.Show("Are you sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.Remove(listView1.Items[0]);

                //Clear Texts
                clearTxts();
            }
        }
        //Clear ListView Item
        private void clearTxts()
        {
            Pilot_ID = "";
            Pilot_Name = "";
            AirCraft_Name = "";
            AirCraft_Model = "";
            Status = "";
        }

    }
}
