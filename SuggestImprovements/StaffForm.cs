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
                            FirstName = au.FirstName,
                            LastName = au.LastName,
                            Department = d.Name,
                            Position = p.Name
                        };

                var staff = q.ToList();
                //var bindingList = new BindingList(proposal);
                //var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = staff;
                dataGridView1.Rows[0].Selected = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex == -1 ? 0 : e.RowIndex].Selected = true;
        }
    }
}
