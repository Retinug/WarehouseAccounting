namespace WarehouseAccounting
{
    partial class FormSearch
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_More = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Less = new System.Windows.Forms.TextBox();
            this.checkBox_More = new System.Windows.Forms.CheckBox();
            this.checkBox_Less = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выбор параметра";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_More
            // 
            this.textBox_More.Location = new System.Drawing.Point(83, 47);
            this.textBox_More.Name = "textBox_More";
            this.textBox_More.Size = new System.Drawing.Size(103, 20);
            this.textBox_More.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Меньше чем";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Больше чем";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_Less);
            this.groupBox1.Controls.Add(this.checkBox_More);
            this.groupBox1.Controls.Add(this.textBox_Less);
            this.groupBox1.Controls.Add(this.textBox_More);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 75);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условие";
            // 
            // textBox_Less
            // 
            this.textBox_Less.Location = new System.Drawing.Point(83, 13);
            this.textBox_Less.Name = "textBox_Less";
            this.textBox_Less.Size = new System.Drawing.Size(103, 20);
            this.textBox_Less.TabIndex = 9;
            // 
            // checkBox_More
            // 
            this.checkBox_More.AutoSize = true;
            this.checkBox_More.Location = new System.Drawing.Point(192, 49);
            this.checkBox_More.Name = "checkBox_More";
            this.checkBox_More.Size = new System.Drawing.Size(41, 17);
            this.checkBox_More.TabIndex = 10;
            this.checkBox_More.Text = "НЕ";
            this.checkBox_More.UseVisualStyleBackColor = true;
            // 
            // checkBox_Less
            // 
            this.checkBox_Less.AutoSize = true;
            this.checkBox_Less.Location = new System.Drawing.Point(192, 15);
            this.checkBox_Less.Name = "checkBox_Less";
            this.checkBox_Less.Size = new System.Drawing.Size(41, 17);
            this.checkBox_Less.TabIndex = 11;
            this.checkBox_Less.Text = "НЕ";
            this.checkBox_Less.UseVisualStyleBackColor = true;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 150);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.Text = "Поиск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_More;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_Less;
        private System.Windows.Forms.CheckBox checkBox_More;
        private System.Windows.Forms.TextBox textBox_Less;
    }
}