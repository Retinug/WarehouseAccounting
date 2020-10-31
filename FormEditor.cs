using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using WarehouseAccounting.Properties;

namespace WarehouseAccounting
{
    public partial class FormEditor : Form
    {
        List<String> Tablenames = new List<String>();

        MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();

        MySqlConnection mySqlConnection;

        MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
        public FormEditor()
        {
            InitializeComponent();

            if (Settings.Default["Server"] != null)
            {
                mySqlConnectionStringBuilder.Server = Settings.Default["Server"].ToString();
                mySqlConnectionStringBuilder.Port = (uint)Settings.Default["Port"];
                mySqlConnectionStringBuilder.UserID = Settings.Default["UserID"].ToString();
                mySqlConnectionStringBuilder.Password = Settings.Default["Password"].ToString();
                mySqlConnectionStringBuilder.Database = Settings.Default["Database"].ToString();
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            MySqlCommand insertCommand = new MySqlCommand($"INSERT INTO {comboBox_SelectTable.SelectedItem}({dataGridView.Columns[0].HeaderText}) VALUES (NULL)");
            insertCommand.Connection = mySqlConnection;

            MySqlDataReader mySqlDataReader = insertCommand.ExecuteReader();
            mySqlDataReader.Read();
            mySqlDataReader.Close();

            updateData();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewCell dataCell = dataGridView.SelectedCells[0];

            MySqlCommand deleteCommand = new MySqlCommand($"DELETE FROM {comboBox_SelectTable.SelectedItem} WHERE {dataCell.OwningColumn.HeaderText} " +
                $"= {dataCell.Value}");

            updateData(deleteCommand);
        }

        private void toolStripMenuItem_Connect_Click(object sender, EventArgs e)
        {

            if (Settings.Default["Server"] == null)
            {
                toolStripMenuItem_Settings_Click(sender, e);
                return;
            }

            mySqlConnection = new MySqlConnection(mySqlConnectionStringBuilder.ToString());

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception)
            {
                throw;
            }

            MySqlCommand mySqlCommand = new MySqlCommand("SHOW TABLES");
            mySqlCommand.Connection = mySqlConnection;

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Tablenames.Add(mySqlDataReader.GetString(0));
            }

            mySqlDataReader.Close();

            comboBox_SelectTable.Items.AddRange(Tablenames.ToArray());
            comboBox_SelectTable.SelectedIndex = 0;

            toolStripMenuItem_Connect.Enabled = false;
            toolStripMenuItem_Disconnect.Enabled = true;
        }

        private void toolStripMenuItem_Disconnect_Click(object sender, EventArgs e)
        {
            mySqlConnection.Close();
            toolStripMenuItem_Disconnect.Enabled = false;
            toolStripMenuItem_Connect.Enabled = true;
            comboBox_SelectTable.Items.Clear();
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            var formSettings = new FormSettings();
            formSettings.ShowDialog();
            if (formSettings.DialogResult == DialogResult.OK)
            {
                mySqlConnectionStringBuilder = formSettings.mySqlConnectionStringBuilder;
            }
        }

        private void comboBox_SelectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySqlDataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM " + comboBox_SelectTable.SelectedItem.ToString(), mySqlConnection);

            updateData();
        }

        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell dataCell = dataGridView.SelectedCells[0];

            MySqlCommand updateCommand = new MySqlCommand($"UPDATE {comboBox_SelectTable.SelectedItem} " +
                $"SET {dataCell.OwningColumn.HeaderText} = " +
                $"\'{dataGridView.CurrentCell.Value}\' " +
                $"WHERE {dataGridView.Columns[0].HeaderText} = {dataGridView.Rows[dataCell.RowIndex].Cells[0].Value}", mySqlConnection);

            updateData(updateCommand);
        }


        private void updateData(MySqlCommand command)
        {
            command.Connection = mySqlConnection;

            MySqlDataReader mySqlDataReader = command.ExecuteReader();
            mySqlDataReader.Read();
            mySqlDataReader.Close();

            updateData();
        }

        private void updateData()
        {
            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
        }
    }
}
