using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class FormSearch : Form
    {
        public string select;
        string action;
        List<String> Tablenames = new List<String>();

        public FormSearch(List<String> tables)
        {
            InitializeComponent();

            Tablenames = tables;

            comboBox_Param.Items.AddRange(Tablenames.ToArray());
            comboBox_Param.SelectedIndex = 0;
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            select = "";

            if (comboBox_Param.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран параметр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textBox_Value.Text == "")
            {
                MessageBox.Show("Не выбрано значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (action == null)
            {
                MessageBox.Show("Не выбрано условие", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            select += $"WHERE {comboBox_Param.SelectedItem} {action} \'{textBox_Value.Text}\'";
        }

        private void radioButton_Condition_Click(object sender, EventArgs e)
        {
            RadioButton button = sender as RadioButton;
            action = button.Text;
        }
    }
}
