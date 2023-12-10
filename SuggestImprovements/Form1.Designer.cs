namespace SuggestImprovements
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.report_button = new System.Windows.Forms.Button();
            this.addDepButton = new System.Windows.Forms.Button();
            this.Authors_button = new System.Windows.Forms.Button();
            this.Position_button = new System.Windows.Forms.Button();
            this.Filter_comboBox = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Refreshbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(668, 282);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(38, 12);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(75, 23);
            this.report_button.TabIndex = 1;
            this.report_button.Text = "Отчеты";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // addDepButton
            // 
            this.addDepButton.Location = new System.Drawing.Point(119, 12);
            this.addDepButton.Name = "addDepButton";
            this.addDepButton.Size = new System.Drawing.Size(100, 23);
            this.addDepButton.TabIndex = 2;
            this.addDepButton.Text = "Подразделения";
            this.addDepButton.UseVisualStyleBackColor = true;
            this.addDepButton.Click += new System.EventHandler(this.addPositionButton_Click);
            // 
            // Authors_button
            // 
            this.Authors_button.Location = new System.Drawing.Point(225, 12);
            this.Authors_button.Name = "Authors_button";
            this.Authors_button.Size = new System.Drawing.Size(75, 23);
            this.Authors_button.TabIndex = 3;
            this.Authors_button.Text = "Персонал";
            this.Authors_button.UseVisualStyleBackColor = true;
            this.Authors_button.Click += new System.EventHandler(this.Authors_button_Click);
            // 
            // Position_button
            // 
            this.Position_button.Location = new System.Drawing.Point(306, 12);
            this.Position_button.Name = "Position_button";
            this.Position_button.Size = new System.Drawing.Size(75, 23);
            this.Position_button.TabIndex = 4;
            this.Position_button.Text = "Positions";
            this.Position_button.UseVisualStyleBackColor = true;
            this.Position_button.Visible = false;
            this.Position_button.Click += new System.EventHandler(this.Position_button_Click_1);
            // 
            // Filter_comboBox
            // 
            this.Filter_comboBox.FormattingEnabled = true;
            this.Filter_comboBox.Location = new System.Drawing.Point(585, 12);
            this.Filter_comboBox.Name = "Filter_comboBox";
            this.Filter_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Filter_comboBox.TabIndex = 6;
            this.Filter_comboBox.Text = "Подразделение";
            this.Filter_comboBox.SelectedIndexChanged += new System.EventHandler(this.Filter_comboBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(403, 360);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(322, 361);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(241, 361);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 8;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Refreshbutton
            // 
            this.Refreshbutton.Image = ((System.Drawing.Image)(resources.GetObject("Refreshbutton.Image")));
            this.Refreshbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Refreshbutton.Location = new System.Drawing.Point(504, 12);
            this.Refreshbutton.Name = "Refreshbutton";
            this.Refreshbutton.Size = new System.Drawing.Size(75, 23);
            this.Refreshbutton.TabIndex = 11;
            this.Refreshbutton.Text = "Обновить";
            this.Refreshbutton.UseVisualStyleBackColor = true;
            this.Refreshbutton.Click += new System.EventHandler(this.Refreshbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 424);
            this.Controls.Add(this.Refreshbutton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.Filter_comboBox);
            this.Controls.Add(this.Position_button);
            this.Controls.Add(this.Authors_button);
            this.Controls.Add(this.addDepButton);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Main Window";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button report_button;
        private Button addDepButton;
        private Button Authors_button;
        private Button Position_button;
        private ComboBox Filter_comboBox;
        private Button DeleteButton;
        private Button AddButton;
        private Button EditButton;
        private Button Refreshbutton;
    }
}