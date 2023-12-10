using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuggestImprovements
{
    public partial class AddPosition : Form
    {
        DataBase db = new DataBase();
        public AddPosition()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AddPosition_Load(object sender, EventArgs e)
        {
            //var queryListCodeRequestAreas = "SELECT * FROM public.\"Areas\";";
            //loadElementToComboBox(queryListCodeRequestAreas, "Name", Area_cbx);

            //var queryListCodeRequestAuthors = "SELECT * FROM public.\"Authors\";";
            //loadElementToComboBox(queryListCodeRequestAuthors, "FirstName",  Author_cbx);

            //var queryListCodeRequestLosses = "SELECT * FROM public.\"Losses\";";
            //loadElementToComboBox(queryListCodeRequestLosses, "Name", Loss_cbx);

            //var queryListCodeRequestJudgments = "SELECT * FROM public.\"Judgments\";";
            //loadElementToComboBox(queryListCodeRequestJudgments, "Name", Judgment_cbx);

            //LoadArea_cbx();

            using (var context = new LeanSiContext())
            {
                var authors = context.Authors.Select(a => a.FirstName).ToList();
                Author_cbx.Items.AddRange(authors.ToArray());
                var areas = context.Areas.Select(a => a.Name).ToList();
                Area_cbx.Items.AddRange(areas.ToArray());
                var losses = context.Losses.Select(a => a.Name).ToList();
                Loss_cbx.Items.AddRange(losses.ToArray());
                var judg = context.Judgments.Select(a => a.Name).ToList();
                Judgment_cbx.Items.AddRange(judg.ToArray());
            }
        }

        //public void loadElementToComboBox(string stringQuery, string column, System.Windows.Forms.ComboBox myBox)
        //{
        //    List<string> columnValues = GetColumnValues(stringQuery, column);
        //    myBox.Items.AddRange(columnValues.ToArray());
        //}
        //public List<string> GetColumnValues(string query, string columnName)
        //{
        //    List<string> columnValues = new List<string>();

        //    db.OpenConnection();

        //    using (NpgsqlCommand command = new NpgsqlCommand(query, db.GetConnection()))
        //    {
        //        NpgsqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            object columnValueObject = reader.GetValue(reader.GetOrdinal(columnName));
        //            string columnValue = columnValueObject != DBNull.Value ? columnValueObject.ToString() : "";
        //            columnValues.Add(columnValue);
        //        }
        //    }

        //    db.CloseConnection();
        //    return columnValues;
        //}

        private void LoadArea_cbx()
        {
            Area.GetArea();
            Area_cbx.DataSource = Area.dtArea;
            Area_cbx.DisplayMember = "Name";
            Area_cbx.ValueMember = "ID";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            db.OpenConnection();

            //var type = Description_textbx.Text;

            //var addQuery = $"INSERT INTO public.\"Positions\"(\"Name\")\r\nVALUES ('{type}');";

            //var command = new NpgsqlCommand(addQuery, db.GetConnection());
            //command.ExecuteNonQuery();

            //MessageBox.Show("Запись создана", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (var context = new LeanSiContext())
            {
                var proposal = new ProposalKeys
                {
                    Date = DateTimeExtensions.DateOnlyFromDateTime(dateTimePicker1.Value),
                    Author = Author_cbx.SelectedIndex + 1,
                    Area = Area_cbx.SelectedIndex + 1,
                    Loss = Loss_cbx.SelectedIndex + 1,
                    Judgment = Judgment_cbx.SelectedIndex + 1,
                    Description = Description_textbx.Text.ToString(),
                    Costs = Convert.ToInt32(Cost_textbx.Text),
                    EconomicEffect = Convert.ToInt32(Economic_textbx.Text),
                    ActualCosts = default,
                    IsCompleted = default,
                    DateComplete = default
                };

                context.Proposals.Add(proposal);
                context.SaveChanges();
            }

            MessageBox.Show("Запись создана", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

            db.CloseConnection();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
