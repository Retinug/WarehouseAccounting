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

            Settings.Default["Server"] = "localhost";
            Settings.Default["Port"] = (uint)3306;
            Settings.Default["UserID"] = "root";
            Settings.Default["Password"] = "";
            Settings.Default["Database"] = "warehouse";
            Settings.Default.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        
        }

        private void toolStripMenuItem_Connect_Click(object sender, EventArgs e)
        {

            if(Settings.Default["Server"] == null)
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

            comboBox_SelectTable.Items.AddRange(Tablenames.ToArray());

            comboBox_SelectTable.SelectedIndex = 0;

            toolStripMenuItem_Connect.Enabled = false;
        }

        private void toolStripMenuItem_Disconnect_Click(object sender, EventArgs e)
        {
            toolStripMenuItem_Disconnect.Enabled = true;
        }

        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            var formSettings = new FormSettings();
            formSettings.ShowDialog();
            if(formSettings.DialogResult == DialogResult.OK)
            {
                mySqlConnectionStringBuilder = formSettings.mySqlConnectionStringBuilder;

            }
        }
    }
}
