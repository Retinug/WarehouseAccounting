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
    public partial class FormSettings : Form
    {
        public MySqlConnectionStringBuilder mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder();
        public FormSettings()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            
            mySqlConnectionStringBuilder.Server = textBox_Server.Text;
            mySqlConnectionStringBuilder.Port = (uint)numericUpDown_Port.Value;
            mySqlConnectionStringBuilder.Database = textBox_Database.Text;
            mySqlConnectionStringBuilder.UserID = textBox_UserID.Text;
            mySqlConnectionStringBuilder.Password = textBox_Password.Text;
        }
    }
}
