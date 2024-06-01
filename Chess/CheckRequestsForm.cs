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

namespace Chess
{
    public partial class CheckRequestsForm : Form
    {
        public CheckRequestsForm()
        {
            InitializeComponent();

            Icon = new Icon(Globals.IconPath);
        }

        private void RefreshListBox()
        {
            listBoxRequests.Items.Clear();
            using SqlConnection connection = new(Globals.ConnectionString);

            try
            {
                connection.Open();

                string query = @"
                    SELECT username FROM JoinRequests
                    WHERE game_id = @game_id";

                using SqlCommand command = new(query, connection);
                command.Parameters.AddWithValue("@game_id", HostGameForm.GameId);

                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBoxRequests.Items.Add(reader.GetString(0));
                    }
                }
                else
                {
                    MessageBox.Show("No requests found!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void AcceptSelectedRequest()
        {

        }

        private void ButtonAccept_Click(object sender, EventArgs e)
        {

        }

        private void AcceptToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RefreshToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }
    }
}