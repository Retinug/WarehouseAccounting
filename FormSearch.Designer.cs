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
            this.comboBox_Param = new System.Windows.Forms.ComboBox();
            this.label_Param = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_Value = new System.Windows.Forms.Label();
            this.groupBox_Sort = new System.Windows.Forms.GroupBox();
            this.groupBox_Condition = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel_Condition = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.textBox_Value = new System.Windows.Forms.TextBox();
            this.groupBox_Sort.SuspendLayout();
            this.groupBox_Condition.SuspendLayout();
            this.tableLayoutPanel_Condition.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_Param
            // 
            this.comboBox_Param.FormattingEnabled = true;
            this.comboBox_Param.Location = new System.Drawing.Point(117, 10);
            this.comboBox_Param.Name = "comboBox_Param";
            this.comboBox_Param.Size = new System.Drawing.Size(85, 21);
            this.comboBox_Param.TabIndex = 0;
            // 
            // label_Param
            // 
            this.label_Param.AutoSize = true;
            this.label_Param.Location = new System.Drawing.Point(9, 13);
            this.label_Param.Name = "label_Param";
            this.label_Param.Size = new System.Drawing.Size(98, 13);
            this.label_Param.TabIndex = 1;
            this.label_Param.Text = "Выбор параметра";
            // 
            // button_Search
            // 
            this.button_Search.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Search.Location = new System.Drawing.Point(12, 182);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(201, 23);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_Value
            // 
            this.label_Value.AutoSize = true;
            this.label_Value.Location = new System.Drawing.Point(7, 16);
            this.label_Value.Name = "label_Value";
            this.label_Value.Size = new System.Drawing.Size(55, 13);
            this.label_Value.TabIndex = 5;
            this.label_Value.Text = "Значение";
            // 
            // groupBox_Sort
            // 
            this.groupBox_Sort.Controls.Add(this.groupBox_Condition);
            this.groupBox_Sort.Controls.Add(this.textBox_Value);
            this.groupBox_Sort.Controls.Add(this.label_Value);
            this.groupBox_Sort.Location = new System.Drawing.Point(12, 37);
            this.groupBox_Sort.Name = "groupBox_Sort";
            this.groupBox_Sort.Size = new System.Drawing.Size(201, 139);
            this.groupBox_Sort.TabIndex = 8;
            this.groupBox_Sort.TabStop = false;
            this.groupBox_Sort.Text = "Условие";
            // 
            // groupBox_Condition
            // 
            this.groupBox_Condition.Controls.Add(this.tableLayoutPanel_Condition);
            this.groupBox_Condition.Location = new System.Drawing.Point(10, 39);
            this.groupBox_Condition.Name = "groupBox_Condition";
            this.groupBox_Condition.Size = new System.Drawing.Size(180, 94);
            this.groupBox_Condition.TabIndex = 10;
            this.groupBox_Condition.TabStop = false;
            this.groupBox_Condition.Text = "Условие";
            // 
            // tableLayoutPanel_Condition
            // 
            this.tableLayoutPanel_Condition.ColumnCount = 3;
            this.tableLayoutPanel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Condition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel_Condition.Controls.Add(this.radioButton4, 2, 0);
            this.tableLayoutPanel_Condition.Controls.Add(this.radioButton1, 0, 0);
            this.tableLayoutPanel_Condition.Controls.Add(this.radioButton6, 0, 1);
            this.tableLayoutPanel_Condition.Controls.Add(this.radioButton2, 2, 1);
            this.tableLayoutPanel_Condition.Controls.Add(this.radioButton3, 1, 1);
            this.tableLayoutPanel_Condition.Controls.Add(this.radioButton5, 1, 0);
            this.tableLayoutPanel_Condition.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel_Condition.Name = "tableLayoutPanel_Condition";
            this.tableLayoutPanel_Condition.RowCount = 2;
            this.tableLayoutPanel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Condition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_Condition.Size = new System.Drawing.Size(168, 69);
            this.tableLayoutPanel_Condition.TabIndex = 0;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(115, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "<=";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton_Condition_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "=";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton_Condition_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(3, 37);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(34, 17);
            this.radioButton6.TabIndex = 11;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "!=";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton_Condition_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(115, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(37, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = ">=";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton_Condition_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(59, 37);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = ">";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton_Condition_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(59, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 10;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "<";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton_Condition_Click);
            // 
            // textBox_Value
            // 
            this.textBox_Value.Location = new System.Drawing.Point(83, 13);
            this.textBox_Value.Name = "textBox_Value";
            this.textBox_Value.Size = new System.Drawing.Size(107, 20);
            this.textBox_Value.TabIndex = 9;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 217);
            this.Controls.Add(this.groupBox_Sort);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.label_Param);
            this.Controls.Add(this.comboBox_Param);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.Text = "Поиск";
            this.groupBox_Sort.ResumeLayout(false);
            this.groupBox_Sort.PerformLayout();
            this.groupBox_Condition.ResumeLayout(false);
            this.tableLayoutPanel_Condition.ResumeLayout(false);
            this.tableLayoutPanel_Condition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Param;
        private System.Windows.Forms.Label label_Param;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_Value;
        private System.Windows.Forms.GroupBox groupBox_Sort;
        private System.Windows.Forms.TextBox textBox_Value;
        private System.Windows.Forms.GroupBox groupBox_Condition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Condition;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton5;
    }
}