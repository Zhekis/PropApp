using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;

namespace SuggestImprovements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillGridView();
            SetComboValues();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            FillGridView();
            Filter_comboBox.Text = "Все подразделения";
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            ReportForm form = new ReportForm();
            form.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProposal form = new AddProposal();
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int authorKey = GetAuthorKey(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            int areaKey = GetAreaKey(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            int lossKey = GetLossKey(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            int judgKey = GetJudgmentKey(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());

            AddProposal form = new AddProposal(new ProposalKeys()
            {
                Author = authorKey,
                Area = areaKey,
                Loss = lossKey,
                Judgment = judgKey
            });

            form.ShowDialog();
        }

        private int GetJudgmentKey(string name)
        {
            int result;

            using (LeanSiContext context = new LeanSiContext())
            {
                result = context.Judgments
                    .AsNoTracking()
                    .Where(x => x.Name == name)
                    .Select(z => z.Id)
                    .FirstOrDefault();
            }

            return result;
        }

        private int GetAuthorKey(string name)
        {
            int result;

            using (LeanSiContext context = new LeanSiContext())
            {
                result = context.Authors
                    .AsNoTracking()
                    .Where(x => x.FirstName + " " + x.LastName == name)
                    .Select(z => z.Id)
                    .FirstOrDefault();
            }

            return result;
        }

        private int GetAreaKey(string name)
        {
            int result;

            using(LeanSiContext context = new LeanSiContext())
            {
                result = context.Areas
                    .AsNoTracking()
                    .Where(x => x.Name == name)
                    .Select(z => z.Id)
                    .FirstOrDefault();
            }

            return result;
        }

        private int GetLossKey(string name)
        {
            int result;

            using (LeanSiContext context = new LeanSiContext())
            {
                result = context.Losses
                    .AsNoTracking()
                    .Where(x => x.Name == name)
                    .Select(z => z.Id)
                    .FirstOrDefault();
            }

            return result;
        }

        private void FillGridView()
        {
            using(LeanSiContext context = new LeanSiContext())
            {
                var q = from p in context.Proposals.AsNoTracking()
                        join a in context.Areas.AsNoTracking() on p.Area equals a.Id
                        join l in context.Losses.AsNoTracking() on p.Loss equals l.Id
                        join au in context.Authors.AsNoTracking() on p.Author equals au.Id
                        join d in context.Departments.AsNoTracking() on au.Department equals d.Id
                        join j in context.Judgments.AsNoTracking() on p.Judgment equals j.Id
                        select new ProposalElem
                        {
                            Number = p.Number,
                            Date = p.Date,
                            Author = au.FirstName + " " +  au.LastName,
                            Department = d.Name,
                            Area = a.Name,
                            Loss = l.Name,
                            Judgment = j.Name,
                            Description = p.Description,
                            Costs = p.Costs,
                            ActualCosts = p.ActualCosts,
                            EconomicEffect = p.EconomicEffect,
                            IsCompleted = p.IsCompleted,
                            DateComplete = p.DateComplete
                        };

                var proposal = q.ToList();
                var bindingList = new BindingList<ProposalElem>(proposal);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns[0].HeaderText = "Номер ППУ";
                dataGridView1.Columns[1].HeaderText = "Дата";
                dataGridView1.Columns[2].HeaderText = "Автор";
                dataGridView1.Columns[3].HeaderText = "Подразделение";
                dataGridView1.Columns[4].HeaderText = "Область улучшения";
                dataGridView1.Columns[5].HeaderText = "Вид потери";
                dataGridView1.Columns[6].HeaderText = "Решение тех. совета";
                dataGridView1.Columns[7].HeaderText = "Описание";
                dataGridView1.Columns[8].HeaderText = "Планируемые затраты";
                dataGridView1.Columns[9].HeaderText = "Фактические затраты";
                dataGridView1.Columns[10].HeaderText = "Экономический эффект";
                dataGridView1.Columns[11].HeaderText = "Выполнено";
                dataGridView1.Columns[12].HeaderText = "Дата реализации";
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex == -1 ? 0 : e.RowIndex].Selected = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var proposal = context.Proposals.AsNoTracking()
                    .Where(x =>
                    x.Author == GetAuthorKey(dataGridView1.SelectedRows[0].Cells[2].Value.ToString())
                    && x.Number == (Int32)dataGridView1.SelectedRows[0].Cells[0].Value
                    ).FirstOrDefault();

                context.Remove(proposal);
                context.SaveChanges();
                MessageBox.Show("Запись Удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SetComboValues()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var dep = context.Departments.Select(a => a.Name).ToList();
                Filter_comboBox.Items.AddRange(dep.ToArray());
            }
        }

        private void Filter_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterDepartment();
        }

        private void FilterDepartment()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var q = from p in context.Proposals.AsNoTracking()
                        join a in context.Areas.AsNoTracking() on p.Area equals a.Id
                        join l in context.Losses.AsNoTracking() on p.Loss equals l.Id
                        join au in context.Authors.AsNoTracking() on p.Author equals au.Id
                        join d in context.Departments.AsNoTracking() on au.Department equals d.Id
                        join j in context.Judgments.AsNoTracking() on p.Judgment equals j.Id
                        where d.Name == Filter_comboBox.Text
                        select new ProposalElem
                        {
                            Number = p.Number,
                            Date = p.Date,
                            Author = au.FirstName + " " + au.LastName,
                            Department = d.Name,
                            Area = a.Name,
                            Loss = l.Name,
                            Judgment = j.Name,
                            Description = p.Description,
                            Costs = p.Costs,
                            ActualCosts = p.ActualCosts,
                            EconomicEffect = p.EconomicEffect,
                            IsCompleted = p.IsCompleted,
                            DateComplete = p.DateComplete
                        };

                var proposal = q.ToList();
                var bindingList = new BindingList<ProposalElem>(proposal);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
            }
        }

        private void Authors_button_Click(object sender, EventArgs e)
        {
            StaffForm form = new StaffForm();
            form.ShowDialog();
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            FillGridView();
            Filter_comboBox.ResetText();
            Filter_comboBox.Text = "Все подразделения";
        }
    }
}