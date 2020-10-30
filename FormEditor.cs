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

namespace WarehouseAccounting
{
    public partial class FormEditor : Form
    {
        List<String> Tablenames = new List<String>();


        public FormEditor()
        {
            InitializeComponent();

            
            MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();

            mySqlConnectionStringBuilder.Server = "localhost";
            mySqlConnectionStringBuilder.Port = 3306;
            mySqlConnectionStringBuilder.Database = "warehouse";
            mySqlConnectionStringBuilder.UserID = "root";
            mySqlConnectionStringBuilder.Password = "";
            MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionStringBuilder.ToString());

            
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

            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();

            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

            while (mySqlDataReader.Read())
            {
                Tablenames.Add(mySqlDataReader.GetString(0));
            }


            comboBox_SelectTable.Items.AddRange(Tablenames.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formSettings = new FormSettings();
            formSettings.Show();            
        }
    }
}
