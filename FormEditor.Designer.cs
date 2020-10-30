namespace WarehouseAccounting
{
    partial class FormEditor
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_SelectTable = new System.Windows.Forms.ComboBox();
            this.label_SelectTable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 335);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 362);
            this.panel1.TabIndex = 1;
            // 
            // comboBox_SelectTable
            // 
            this.comboBox_SelectTable.FormattingEnabled = true;
            this.comboBox_SelectTable.Location = new System.Drawing.Point(288, 368);
            this.comboBox_SelectTable.Name = "comboBox_SelectTable";
            this.comboBox_SelectTable.Size = new System.Drawing.Size(230, 21);
            this.comboBox_SelectTable.TabIndex = 2;
            // 
            // label_SelectTable
            // 
            this.label_SelectTable.AutoSize = true;
            this.label_SelectTable.Location = new System.Drawing.Point(196, 371);
            this.label_SelectTable.Name = "label_SelectTable";
            this.label_SelectTable.Size = new System.Drawing.Size(86, 13);
            this.label_SelectTable.TabIndex = 3;
            this.label_SelectTable.Text = "Выбор таблицы";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Connect,
            this.toolStripMenuItem_Disconnect,
            this.toolStripMenuItem_Settings});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // toolStripMenuItem_Connect
            // 
            this.toolStripMenuItem_Connect.Name = "toolStripMenuItem_Connect";
            this.toolStripMenuItem_Connect.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Connect.Text = "Соединить";
            this.toolStripMenuItem_Connect.Click += new System.EventHandler(this.toolStripMenuItem_Connect_Click);
            // 
            // toolStripMenuItem_Disconnect
            // 
            this.toolStripMenuItem_Disconnect.Enabled = false;
            this.toolStripMenuItem_Disconnect.Name = "toolStripMenuItem_Disconnect";
            this.toolStripMenuItem_Disconnect.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Disconnect.Text = "Отсоединить";
            this.toolStripMenuItem_Disconnect.Click += new System.EventHandler(this.toolStripMenuItem_Disconnect_Click);
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem_Settings.Text = "Настройка";
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 401);
            this.Controls.Add(this.label_SelectTable);
            this.Controls.Add(this.comboBox_SelectTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEditor";
            this.Text = "Учет склада";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_SelectTable;
        private System.Windows.Forms.Label label_SelectTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Connect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Disconnect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
    }
}

