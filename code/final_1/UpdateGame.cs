﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_1
{
    public partial class UpdateGame : Form
    {
        public UpdateGame()
        {
            InitializeComponent();
        }

        private void UpdateGame_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=HASSANSAMIR;Initial Catalog=GameRental;Integrated Security=True");
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlcon;
            sqlcon.Open();
            sqlcommand.CommandText = "UPDATE Game SET  category = '" + textBox2.Text + "' , game_year = '" + textBox3.Text + "' ,  game_month = '" + textBox4.Text + "' WHERE game_name = '" + textBox1.Text + "'";
            sqlcommand.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("The game updated successfully");
            AdminPage Ap = new AdminPage();
            Ap.Show();
            this.Hide();
        }
    }
}
