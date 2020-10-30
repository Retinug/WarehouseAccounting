namespace WarehouseAccounting
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.label_Database = new System.Windows.Forms.Label();
            this.label_Server = new System.Windows.Forms.Label();
            this.label_Port = new System.Windows.Forms.Label();
            this.textBox_UserID = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.label_UserID = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.numericUpDown_Port = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Port)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(89, 6);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(205, 20);
            this.textBox_Server.TabIndex = 0;
            // 
            // label_Database
            // 
            this.label_Database.AutoSize = true;
            this.label_Database.Location = new System.Drawing.Point(3, 113);
            this.label_Database.Name = "label_Database";
            this.label_Database.Size = new System.Drawing.Size(72, 13);
            this.label_Database.TabIndex = 1;
            this.label_Database.Text = "База данных";
            // 
            // label_Server
            // 
            this.label_Server.AutoSize = true;
            this.label_Server.Location = new System.Drawing.Point(3, 9);
            this.label_Server.Name = "label_Server";
            this.label_Server.Size = new System.Drawing.Size(44, 13);
            this.label_Server.TabIndex = 2;
            this.label_Server.Text = "Сервер";
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Location = new System.Drawing.Point(3, 35);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(32, 13);
            this.label_Port.TabIndex = 3;
            this.label_Port.Text = "Порт";
            // 
            // textBox_UserID
            // 
            this.textBox_UserID.Location = new System.Drawing.Point(89, 58);
            this.textBox_UserID.Name = "textBox_UserID";
            this.textBox_UserID.Size = new System.Drawing.Size(205, 20);
            this.textBox_UserID.TabIndex = 5;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(89, 84);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(205, 20);
            this.textBox_Password.TabIndex = 6;
            // 
            // textBox_Database
            // 
            this.textBox_Database.Location = new System.Drawing.Point(89, 110);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(205, 20);
            this.textBox_Database.TabIndex = 7;
            // 
            // label_UserID
            // 
            this.label_UserID.AutoSize = true;
            this.label_UserID.Location = new System.Drawing.Point(3, 61);
            this.label_UserID.Name = "label_UserID";
            this.label_UserID.Size = new System.Drawing.Size(80, 13);
            this.label_UserID.TabIndex = 8;
            this.label_UserID.Text = "Пользователь";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(3, 87);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(45, 13);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Пароль";
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(6, 143);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(288, 23);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // numericUpDown_Port
            // 
            this.numericUpDown_Port.Location = new System.Drawing.Point(89, 33);
            this.numericUpDown_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_Port.Name = "numericUpDown_Port";
            this.numericUpDown_Port.Size = new System.Drawing.Size(205, 20);
            this.numericUpDown_Port.TabIndex = 11;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 178);
            this.Controls.Add(this.numericUpDown_Port);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserID);
            this.Controls.Add(this.textBox_Database);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserID);
            this.Controls.Add(this.label_Port);
            this.Controls.Add(this.label_Server);
            this.Controls.Add(this.label_Database);
            this.Controls.Add(this.textBox_Server);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Text = "Настройка соединения";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.Label label_Database;
        private System.Windows.Forms.Label label_Server;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.TextBox textBox_UserID;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.Label label_UserID;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.NumericUpDown numericUpDown_Port;
    }
}