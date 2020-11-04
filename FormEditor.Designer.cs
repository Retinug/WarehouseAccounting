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
            this.button_Foreign = new System.Windows.Forms.Button();
            this.button_SelectAll = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.comboBox_SelectTable = new System.Windows.Forms.ComboBox();
            this.label_SelectTable = new System.Windows.Forms.Label();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Disconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox_Prod = new System.Windows.Forms.ComboBox();
            this.label_Prod = new System.Windows.Forms.Label();
            this.label_Count = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(199, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(319, 335);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Count);
            this.panel1.Controls.Add(this.label_Prod);
            this.panel1.Controls.Add(this.comboBox_Prod);
            this.panel1.Controls.Add(this.button_Foreign);
            this.panel1.Controls.Add(this.button_SelectAll);
            this.panel1.Controls.Add(this.button_Update);
            this.panel1.Controls.Add(this.button_Search);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Add);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 362);
            this.panel1.TabIndex = 1;
            // 
            // button_Foreign
            // 
            this.button_Foreign.Location = new System.Drawing.Point(4, 334);
            this.button_Foreign.Name = "button_Foreign";
            this.button_Foreign.Size = new System.Drawing.Size(171, 23);
            this.button_Foreign.TabIndex = 5;
            this.button_Foreign.Text = "Показ с внешними ключами";
            this.button_Foreign.UseVisualStyleBackColor = true;
            this.button_Foreign.Click += new System.EventHandler(this.button_Foreign_Click);
            // 
            // button_SelectAll
            // 
            this.button_SelectAll.Location = new System.Drawing.Point(4, 91);
            this.button_SelectAll.Name = "button_SelectAll";
            this.button_SelectAll.Size = new System.Drawing.Size(171, 23);
            this.button_SelectAll.TabIndex = 4;
            this.button_SelectAll.Text = "Просмотр всех";
            this.button_SelectAll.UseVisualStyleBackColor = true;
            this.button_SelectAll.Click += new System.EventHandler(this.button_SelectAll_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(4, 62);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(171, 23);
            this.button_Update.TabIndex = 3;
            this.button_Update.Text = "Обновить";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(4, 120);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(171, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(4, 33);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(171, 23);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(4, 4);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(171, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
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
            this.menuStrip_Main.Size = new System.Drawing.Size(531, 24);
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
            // comboBox_Prod
            // 
            this.comboBox_Prod.FormattingEnabled = true;
            this.comboBox_Prod.Location = new System.Drawing.Point(4, 178);
            this.comboBox_Prod.Name = "comboBox_Prod";
            this.comboBox_Prod.Size = new System.Drawing.Size(171, 21);
            this.comboBox_Prod.TabIndex = 8;
            this.comboBox_Prod.SelectedIndexChanged += new System.EventHandler(this.comboBox_Prod_SelectedIndexChanged);
            // 
            // label_Prod
            // 
            this.label_Prod.AutoSize = true;
            this.label_Prod.Location = new System.Drawing.Point(1, 162);
            this.label_Prod.Name = "label_Prod";
            this.label_Prod.Size = new System.Drawing.Size(136, 13);
            this.label_Prod.TabIndex = 9;
            this.label_Prod.Text = "Поиск по производителю";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(3, 202);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(69, 13);
            this.label_Count.TabIndex = 5;
            this.label_Count.Text = "Количество:";
            this.label_Count.Visible = false;
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 401);
            this.Controls.Add(this.label_SelectTable);
            this.Controls.Add(this.comboBox_SelectTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.MaximumSize = new System.Drawing.Size(1000, 440);
            this.MinimumSize = new System.Drawing.Size(547, 440);
            this.Name = "FormEditor";
            this.Text = "Учет склада";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Connect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Disconnect;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_SelectAll;
        private System.Windows.Forms.Button button_Foreign;
        private System.Windows.Forms.ComboBox comboBox_Prod;
        private System.Windows.Forms.Label label_Prod;
        private System.Windows.Forms.Label label_Count;
    }
}

