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
    public partial class FormSettings : Form
    {
        public MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
        public FormSettings()
        {
            InitializeComponent();
            Settings.Default["Server"] = "localhost";
            Settings.Default["Port"] = (uint)3306;
            Settings.Default["UserID"] = "root";
            Settings.Default["Password"] = "";
            Settings.Default["Database"] = "warehouse";

            if (Settings.Default["Server"] != null)
            {
                textBox_Server.Text = Settings.Default["Server"].ToString();
                numericUpDown_Port.Value = (uint)Settings.Default["Port"];
                textBox_UserID.Text = Settings.Default["UserID"].ToString();
                textBox_Password.Text = Settings.Default["Password"].ToString();
                textBox_Database.Text = Settings.Default["Database"].ToString();
            }

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            
            mySqlConnectionStringBuilder.Server = textBox_Server.Text;
            mySqlConnectionStringBuilder.Port = (uint)numericUpDown_Port.Value;
            mySqlConnectionStringBuilder.UserID = textBox_UserID.Text;
            mySqlConnectionStringBuilder.Password = textBox_Password.Text;
            mySqlConnectionStringBuilder.Database = textBox_Database.Text;
        }
    }
}
