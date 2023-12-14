using Microsoft.EntityFrameworkCore;
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
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void StaffForm_Activated(object sender, EventArgs e)
        {
            FillGridView();
        }

        private void FillGridView()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var q = from au in context.Authors.AsNoTracking()
                        join d in context.Departments.AsNoTracking() on au.Department equals d.Id
                        join p in context.Positions.AsNoTracking() on au.Position equals p.Id
                        select new
                        {
                            au.FirstName,
                            au.LastName,
                            Department = d.Name,
                            Position = p.Name
                        };

                var staff = q.ToList();
                dataGridView1.DataSource = staff;
                dataGridView1.Columns[0].HeaderText = "Имя";
                dataGridView1.Columns[1].HeaderText = "Фамилия";
                dataGridView1.Columns[2].HeaderText = "Цех";
                dataGridView1.Columns[3].HeaderText = "Должность";
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex == -1 ? 0 : e.RowIndex].Selected = true;
        }

        private int GetDepartmentKey(string name)
        {
            int result;

            using (LeanSiContext context = new LeanSiContext())
            {
                result = context.Departments
                    .AsNoTracking()
                    .Where(x => x.Name == name)
                    .Select(z => z.Id)
                    .FirstOrDefault();
            }

            return result;
        }

        private int GetPositionKey(string name)
        {
            int result;

            using (LeanSiContext context = new LeanSiContext())
            {
                result = context.Positions
                    .AsNoTracking()
                    .Where(x => x.Name == name)
                    .Select(z => z.Id)
                    .FirstOrDefault();
            }

            return result;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AuthorForm form = new AuthorForm();
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int depKey = GetDepartmentKey(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            int positionKey = GetPositionKey(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            AuthorForm form = new AuthorForm(new Author()
            {
                Department = depKey,
                Position = positionKey
            });

            form.ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var au = context.Authors.AsNoTracking()
                    .Where(x =>
                    x.Department == GetDepartmentKey(dataGridView1.SelectedRows[0].Cells[2].Value.ToString())
                    && x.Position == GetPositionKey(dataGridView1.SelectedRows[0].Cells[3].Value.ToString())
                    && x.FirstName == dataGridView1.SelectedRows[0].Cells[0].Value
                    && x.LastName == dataGridView1.SelectedRows[0].Cells[1].Value
                    ).FirstOrDefault();

                var proposal = context.Proposals.AsNoTracking()
                    .Where(x =>
                    x.Author == au.Id
                    ).FirstOrDefault();

                context.Remove(proposal);
                context.Remove(au);
                context.SaveChanges();
                MessageBox.Show("Запись Удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
