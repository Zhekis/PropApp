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

namespace SuggestImprovements
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private NpgsqlDataAdapter adapter = null;
        DataTable dt;

        private void ReportForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            adapter = new NpgsqlDataAdapter("SELECT d.\"Name\" , COUNT(*) as \"Amount\", SUM(CASE WHEN p.\"IsCompleted\" = true THEN 1 ELSE 0 END) as \"AmountRealised\", SUM(p.\"Costs\") as \"PlanCosts\",\r\nSUM(p.\"ActualCosts\") as \"FactCosts\", (SUM(CASE WHEN p.\"IsCompleted\" = true THEN 1 ELSE 0 END) * 100 / COUNT(*)) as \"%\", SUM(p.\"EconomicEffect\") as \"EE\",\r\nSTRING_AGG(DISTINCT a.\"Name\", ', ') as \"Areas\", STRING_AGG(DISTINCT l.\"Name\", ', ') as \"Losses\"\r\nFROM \"Proposals\" as p\r\nJOIN \"Areas\" as a ON a.\"ID\" = p.\"Area\"\r\nJOIN \"Losses\" as l ON l.\"ID\" = p.\"Loss\"\r\nJOIN \"Authors\" as au ON au.\"ID\" = p.\"Author\"\r\nJOIN \"Departments\" as d ON d.\"ID\" = au.\"Department\"\r\nGROUP BY d.\"Name\";\r\n", db.GetConnection());
            //adapter = new NpgsqlDataAdapter("SELECT * FROM public.\"Proposals\";", db.GetConnection());
            dt = new DataTable();

            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Цех";
            dataGridView1.Columns[1].HeaderText = "Количество ППУ";
            dataGridView1.Columns[2].HeaderText = "Количество реализованых ППУ";
            dataGridView1.Columns[3].HeaderText = "Планируемые затраты";
            dataGridView1.Columns[4].HeaderText = "Фактические затраты";
            dataGridView1.Columns[5].HeaderText = "% реализации";
            dataGridView1.Columns[6].HeaderText = "Экономический эффект";
            dataGridView1.Columns[7].HeaderText = "Области улучшений";
            dataGridView1.Columns[8].HeaderText = "Виды потерь";

            //using (var context = new LeanSiContext())
            //{
            //    var result = from p in context.Proposals
            //                 join a in context.Areas on p.Area equals a.Id
            //                 join l in context.Losses on p.Loss equals l.Id
            //                 join au in context.Authors on p.Author equals au.Id
            //                 join d in context.Departments on au.Department equals d.Id
            //                 // Add more joins for other entities...

            //                 group d by d.Name into g
            //                 select new
            //                 {
            //                     Department = g.Key,
            //                     Amount = g.Count(),
            //                     AmountRealised = g.Count(x => x.IsCompleted),
            //                     PlanCosts = g.Sum(x => x.Costs),
            //                     // Add other fields...
            //                 };

            //    dataGridView1.DataSource = result.ToList();
            //}


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
