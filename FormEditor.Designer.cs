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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_SelectTable = new System.Windows.Forms.ComboBox();
            this.label_SelectTable = new System.Windows.Forms.Label();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(199, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(319, 335);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 362);
            this.panel1.TabIndex = 1;
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
            // comboBox_SelectTable
            // 
            this.comboBox_SelectTable.FormattingEnabled = true;
            this.comboBox_SelectTable.Location = new System.Drawing.Point(288, 368);
            this.comboBox_SelectTable.Name = "comboBox_SelectTable";
            this.comboBox_SelectTable.Size = new System.Drawing.Size(230, 21);
            this.comboBox_SelectTable.TabIndex = 2;
            this.comboBox_SelectTable.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectTable_SelectedIndexChanged);
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
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(530, 24);
            this.menuStrip_Main.TabIndex = 4;
            this.menuStrip_Main.Text = "menuStrip_Main";
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
            this.toolStripMenuItem_Connect.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem_Connect.Text = "Соединить";
            this.toolStripMenuItem_Connect.Click += new System.EventHandler(this.toolStripMenuItem_Connect_Click);
            // 
            // toolStripMenuItem_Disconnect
            // 
            this.toolStripMenuItem_Disconnect.Enabled = false;
            this.toolStripMenuItem_Disconnect.Name = "toolStripMenuItem_Disconnect";
            this.toolStripMenuItem_Disconnect.Size = new System.Drawing.Size(145, 22);
            this.toolStripMenuItem_Disconnect.Text = "Отсоединить";
            this.toolStripMenuItem_Disconnect.Click += new System.EventHandler(this.toolStripMenuItem_Disconnect_Click);
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(145, 22);
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
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "FormEditor";
            this.Text = "Учет склада";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_SelectTable;
        private System.Windows.Forms.Label label_SelectTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Connect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Disconnect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
    }
}

