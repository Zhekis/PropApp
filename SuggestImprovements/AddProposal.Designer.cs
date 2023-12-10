
namespace SuggestImprovements
{
    partial class AddProposal
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
            this.Author_cbx = new System.Windows.Forms.ComboBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Description_textbx = new System.Windows.Forms.TextBox();
            this.Date_label = new System.Windows.Forms.Label();
            this.Author_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Area_cbx = new System.Windows.Forms.ComboBox();
            this.Loss_cbx = new System.Windows.Forms.ComboBox();
            this.Area_label = new System.Windows.Forms.Label();
            this.Loss_label = new System.Windows.Forms.Label();
            this.Judgment_cbx = new System.Windows.Forms.ComboBox();
            this.Judg_label = new System.Windows.Forms.Label();
            this.Description_label = new System.Windows.Forms.Label();
            this.Cost_label = new System.Windows.Forms.Label();
            this.Economic_label = new System.Windows.Forms.Label();
            this.Cost_textbx = new System.Windows.Forms.TextBox();
            this.Economic_textbx = new System.Windows.Forms.TextBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.ActCost_textbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Number_textBox = new System.Windows.Forms.TextBox();
            this.Number_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Author_cbx
            // 
            this.Author_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Author_cbx.FormattingEnabled = true;
            this.Author_cbx.Location = new System.Drawing.Point(24, 87);
            this.Author_cbx.Name = "Author_cbx";
            this.Author_cbx.Size = new System.Drawing.Size(146, 23);
            this.Author_cbx.TabIndex = 0;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(194, 394);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 1;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            this.Save_button.MouseEnter += new System.EventHandler(this.Save_button_MouseEnter);
            // 
            // Description_textbx
            // 
            this.Description_textbx.BackColor = System.Drawing.SystemColors.Window;
            this.Description_textbx.Location = new System.Drawing.Point(24, 265);
            this.Description_textbx.Multiline = true;
            this.Description_textbx.Name = "Description_textbx";
            this.Description_textbx.PlaceholderText = "Введите описание предложения";
            this.Description_textbx.Size = new System.Drawing.Size(490, 67);
            this.Description_textbx.TabIndex = 2;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(24, 25);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(90, 15);
            this.Date_label.TabIndex = 3;
            this.Date_label.Text = "Выбирете дату:";
            // 
            // Author_label
            // 
            this.Author_label.AutoSize = true;
            this.Author_label.Location = new System.Drawing.Point(24, 69);
            this.Author_label.Name = "Author_label";
            this.Author_label.Size = new System.Drawing.Size(43, 15);
            this.Author_label.TabIndex = 4;
            this.Author_label.Text = "Автор:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(146, 23);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // Area_cbx
            // 
            this.Area_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Area_cbx.FormattingEnabled = true;
            this.Area_cbx.Location = new System.Drawing.Point(24, 131);
            this.Area_cbx.Name = "Area_cbx";
            this.Area_cbx.Size = new System.Drawing.Size(146, 23);
            this.Area_cbx.TabIndex = 6;
            // 
            // Loss_cbx
            // 
            this.Loss_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Loss_cbx.FormattingEnabled = true;
            this.Loss_cbx.Location = new System.Drawing.Point(24, 178);
            this.Loss_cbx.Name = "Loss_cbx";
            this.Loss_cbx.Size = new System.Drawing.Size(146, 23);
            this.Loss_cbx.TabIndex = 7;
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Location = new System.Drawing.Point(24, 113);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(56, 15);
            this.Area_label.TabIndex = 8;
            this.Area_label.Text = "Область:";
            // 
            // Loss_label
            // 
            this.Loss_label.AutoSize = true;
            this.Loss_label.Location = new System.Drawing.Point(24, 160);
            this.Loss_label.Name = "Loss_label";
            this.Loss_label.Size = new System.Drawing.Size(72, 15);
            this.Loss_label.TabIndex = 9;
            this.Loss_label.Text = "Вид потери:";
            // 
            // Judgment_cbx
            // 
            this.Judgment_cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Judgment_cbx.FormattingEnabled = true;
            this.Judgment_cbx.Location = new System.Drawing.Point(24, 223);
            this.Judgment_cbx.Name = "Judgment_cbx";
            this.Judgment_cbx.Size = new System.Drawing.Size(146, 23);
            this.Judgment_cbx.TabIndex = 10;
            // 
            // Judg_label
            // 
            this.Judg_label.AutoSize = true;
            this.Judg_label.Location = new System.Drawing.Point(24, 205);
            this.Judg_label.Name = "Judg_label";
            this.Judg_label.Size = new System.Drawing.Size(60, 15);
            this.Judg_label.TabIndex = 11;
            this.Judg_label.Text = "Решение:";
            // 
            // Description_label
            // 
            this.Description_label.AutoSize = true;
            this.Description_label.Location = new System.Drawing.Point(24, 247);
            this.Description_label.Name = "Description_label";
            this.Description_label.Size = new System.Drawing.Size(65, 15);
            this.Description_label.TabIndex = 12;
            this.Description_label.Text = "Описание:";
            // 
            // Cost_label
            // 
            this.Cost_label.AutoSize = true;
            this.Cost_label.Location = new System.Drawing.Point(272, 43);
            this.Cost_label.Name = "Cost_label";
            this.Cost_label.Size = new System.Drawing.Size(55, 15);
            this.Cost_label.TabIndex = 14;
            this.Cost_label.Text = "Затраты:";
            // 
            // Economic_label
            // 
            this.Economic_label.AutoSize = true;
            this.Economic_label.Location = new System.Drawing.Point(364, 43);
            this.Economic_label.Name = "Economic_label";
            this.Economic_label.Size = new System.Drawing.Size(150, 15);
            this.Economic_label.TabIndex = 16;
            this.Economic_label.Text = "Экнономический эффект:";
            // 
            // Cost_textbx
            // 
            this.Cost_textbx.Location = new System.Drawing.Point(272, 61);
            this.Cost_textbx.Name = "Cost_textbx";
            this.Cost_textbx.Size = new System.Drawing.Size(84, 23);
            this.Cost_textbx.TabIndex = 17;
            this.Cost_textbx.TextChanged += new System.EventHandler(this.Cost_textbx_TextChanged);
            // 
            // Economic_textbx
            // 
            this.Economic_textbx.Location = new System.Drawing.Point(391, 61);
            this.Economic_textbx.Name = "Economic_textbx";
            this.Economic_textbx.Size = new System.Drawing.Size(84, 23);
            this.Economic_textbx.TabIndex = 18;
            this.Economic_textbx.TextChanged += new System.EventHandler(this.Economic_textbx_TextChanged);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(291, 394);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_button.TabIndex = 19;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(176, 87);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(17, 23);
            this.AddAuthorButton.TabIndex = 20;
            this.AddAuthorButton.Text = "+";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            // 
            // ActCost_textbx
            // 
            this.ActCost_textbx.Location = new System.Drawing.Point(272, 113);
            this.ActCost_textbx.Name = "ActCost_textbx";
            this.ActCost_textbx.Size = new System.Drawing.Size(84, 23);
            this.ActCost_textbx.TabIndex = 24;
            this.ActCost_textbx.TextChanged += new System.EventHandler(this.ActCost_textbx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "ФактЗатраты:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(272, 175);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(146, 23);
            this.dateTimePicker2.TabIndex = 26;
            this.dateTimePicker2.Value = new System.DateTime(2023, 12, 6, 16, 9, 15, 0);
            this.dateTimePicker2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Дата реализации:";
            this.label3.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(395, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 19);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Реализованно";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Number_textBox
            // 
            this.Number_textBox.Location = new System.Drawing.Point(176, 17);
            this.Number_textBox.Name = "Number_textBox";
            this.Number_textBox.ReadOnly = true;
            this.Number_textBox.Size = new System.Drawing.Size(84, 23);
            this.Number_textBox.TabIndex = 29;
            this.Number_textBox.Visible = false;
            // 
            // Number_label
            // 
            this.Number_label.AutoSize = true;
            this.Number_label.Location = new System.Drawing.Point(176, -1);
            this.Number_label.Name = "Number_label";
            this.Number_label.Size = new System.Drawing.Size(48, 15);
            this.Number_label.TabIndex = 28;
            this.Number_label.Text = "Номер:";
            this.Number_label.Visible = false;
            // 
            // AddProposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 439);
            this.Controls.Add(this.Number_textBox);
            this.Controls.Add(this.Number_label);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActCost_textbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Economic_textbx);
            this.Controls.Add(this.Cost_textbx);
            this.Controls.Add(this.Economic_label);
            this.Controls.Add(this.Cost_label);
            this.Controls.Add(this.Description_label);
            this.Controls.Add(this.Judg_label);
            this.Controls.Add(this.Judgment_cbx);
            this.Controls.Add(this.Loss_label);
            this.Controls.Add(this.Area_label);
            this.Controls.Add(this.Loss_cbx);
            this.Controls.Add(this.Area_cbx);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Author_label);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Description_textbx);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Author_cbx);
            this.Name = "AddProposal";
            this.Text = "Add proposal";
            this.Load += new System.EventHandler(this.AddPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private ComboBox Author_cbx;
        private Button Save_button;
        private TextBox Description_textbx;
        private Label Date_label;
        private Label Author_label;
        private DateTimePicker dateTimePicker1;
        private ComboBox Area_cbx;
        private ComboBox Loss_cbx;
        private Label Area_label;
        private Label Loss_label;
        private ComboBox Judgment_cbx;
        private Label Judg_label;
        private Label Description_label;
        private Label Cost_label;
        private Label Economic_label;
        private TextBox Cost_textbx;
        private TextBox Economic_textbx;
        private Button Cancel_button;
        private Button AddAuthorButton;
        private TextBox ActCost_textbx;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private CheckBox checkBox1;
        private TextBox Number_textBox;
        private Label Number_label;
    }
}