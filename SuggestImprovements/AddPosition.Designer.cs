
namespace SuggestImprovements
{
    partial class AddPosition
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
            Author_cbx = new ComboBox();
            add_button = new Button();
            Description_textbx = new TextBox();
            Date_label = new Label();
            Author_label = new Label();
            dateTimePicker1 = new DateTimePicker();
            Area_cbx = new ComboBox();
            Loss_cbx = new ComboBox();
            Area_label = new Label();
            Loss_label = new Label();
            Judgment_cbx = new ComboBox();
            Judg_label = new Label();
            Description_label = new Label();
            Cost_label = new Label();
            Economic_label = new Label();
            Cost_textbx = new TextBox();
            Economic_textbx = new TextBox();
            Cancel_button = new Button();
            SuspendLayout();
            // 
            // Author_cbx
            // 
            Author_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            Author_cbx.FormattingEnabled = true;
            Author_cbx.Location = new Point(221, 74);
            Author_cbx.Name = "Author_cbx";
            Author_cbx.Size = new Size(146, 23);
            Author_cbx.TabIndex = 0;
            // 
            // add_button
            // 
            add_button.Location = new Point(292, 399);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 1;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += AddButton_Click;
            // 
            // Description_textbx
            // 
            Description_textbx.Location = new Point(221, 252);
            Description_textbx.Multiline = true;
            Description_textbx.Name = "Description_textbx";
            Description_textbx.Size = new Size(300, 67);
            Description_textbx.TabIndex = 2;
            // 
            // Date_label
            // 
            Date_label.AutoSize = true;
            Date_label.Location = new Point(221, 12);
            Date_label.Name = "Date_label";
            Date_label.Size = new Size(90, 15);
            Date_label.TabIndex = 3;
            Date_label.Text = "Выбирете дату:";
            // 
            // Author_label
            // 
            Author_label.AutoSize = true;
            Author_label.Location = new Point(221, 56);
            Author_label.Name = "Author_label";
            Author_label.Size = new Size(43, 15);
            Author_label.TabIndex = 4;
            Author_label.Text = "Автор:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(221, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // Area_cbx
            // 
            Area_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            Area_cbx.FormattingEnabled = true;
            Area_cbx.Location = new Point(221, 118);
            Area_cbx.Name = "Area_cbx";
            Area_cbx.Size = new Size(146, 23);
            Area_cbx.TabIndex = 6;
            // 
            // Loss_cbx
            // 
            Loss_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            Loss_cbx.FormattingEnabled = true;
            Loss_cbx.Location = new Point(221, 165);
            Loss_cbx.Name = "Loss_cbx";
            Loss_cbx.Size = new Size(146, 23);
            Loss_cbx.TabIndex = 7;
            // 
            // Area_label
            // 
            Area_label.AutoSize = true;
            Area_label.Location = new Point(221, 100);
            Area_label.Name = "Area_label";
            Area_label.Size = new Size(56, 15);
            Area_label.TabIndex = 8;
            Area_label.Text = "Область:";
            // 
            // Loss_label
            // 
            Loss_label.AutoSize = true;
            Loss_label.Location = new Point(221, 147);
            Loss_label.Name = "Loss_label";
            Loss_label.Size = new Size(72, 15);
            Loss_label.TabIndex = 9;
            Loss_label.Text = "Вид потери:";
            // 
            // Judgment_cbx
            // 
            Judgment_cbx.DropDownStyle = ComboBoxStyle.DropDownList;
            Judgment_cbx.FormattingEnabled = true;
            Judgment_cbx.Location = new Point(221, 210);
            Judgment_cbx.Name = "Judgment_cbx";
            Judgment_cbx.Size = new Size(146, 23);
            Judgment_cbx.TabIndex = 10;
            // 
            // Judg_label
            // 
            Judg_label.AutoSize = true;
            Judg_label.Location = new Point(221, 192);
            Judg_label.Name = "Judg_label";
            Judg_label.Size = new Size(60, 15);
            Judg_label.TabIndex = 11;
            Judg_label.Text = "Решение:";
            // 
            // Description_label
            // 
            Description_label.AutoSize = true;
            Description_label.Location = new Point(221, 234);
            Description_label.Name = "Description_label";
            Description_label.Size = new Size(65, 15);
            Description_label.TabIndex = 12;
            Description_label.Text = "Описание:";
            // 
            // Cost_label
            // 
            Cost_label.AutoSize = true;
            Cost_label.Location = new Point(222, 322);
            Cost_label.Name = "Cost_label";
            Cost_label.Size = new Size(55, 15);
            Cost_label.TabIndex = 14;
            Cost_label.Text = "Затраты:";
            Cost_label.Click += label7_Click;
            // 
            // Economic_label
            // 
            Economic_label.AutoSize = true;
            Economic_label.Location = new Point(314, 322);
            Economic_label.Name = "Economic_label";
            Economic_label.Size = new Size(150, 15);
            Economic_label.TabIndex = 16;
            Economic_label.Text = "Экнономический эффект:";
            // 
            // Cost_textbx
            // 
            Cost_textbx.Location = new Point(222, 340);
            Cost_textbx.Name = "Cost_textbx";
            Cost_textbx.Size = new Size(84, 23);
            Cost_textbx.TabIndex = 17;
            // 
            // Economic_textbx
            // 
            Economic_textbx.Location = new Point(341, 340);
            Economic_textbx.Name = "Economic_textbx";
            Economic_textbx.Size = new Size(84, 23);
            Economic_textbx.TabIndex = 18;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(389, 399);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(75, 23);
            Cancel_button.TabIndex = 19;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            // 
            // AddPosition
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 439);
            Controls.Add(Cancel_button);
            Controls.Add(Economic_textbx);
            Controls.Add(Cost_textbx);
            Controls.Add(Economic_label);
            Controls.Add(Cost_label);
            Controls.Add(Description_label);
            Controls.Add(Judg_label);
            Controls.Add(Judgment_cbx);
            Controls.Add(Loss_label);
            Controls.Add(Area_label);
            Controls.Add(Loss_cbx);
            Controls.Add(Area_cbx);
            Controls.Add(dateTimePicker1);
            Controls.Add(Author_label);
            Controls.Add(Date_label);
            Controls.Add(Description_textbx);
            Controls.Add(add_button);
            Controls.Add(Author_cbx);
            Name = "AddPosition";
            Text = "Form2";
            Load += AddPosition_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ComboBox Author_cbx;
        private Button add_button;
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
    }
}