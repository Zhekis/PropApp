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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SuggestImprovements
{
    public partial class AuthorForm : Form
    {
        private Author? _key;
        private IDictionary<int, string> _depKeys;
        private IDictionary<int, string> _positionKeys;

        public AuthorForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _key = null;
            _depKeys = new Dictionary<int, string>();
            _positionKeys = new Dictionary<int, string>();
        }

        public AuthorForm(Author? key)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _key = key;
            _depKeys = new Dictionary<int, string>();
            _positionKeys = new Dictionary<int, string>();
        }

        private void FillDepartment()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var q = from dep in context.Departments.AsNoTracking()
                        orderby dep.Name
                        select dep;

                var depList = q.ToList();

                dep_comboBox.Items.Clear();
                _depKeys.Clear();

                depList.ForEach(delegate (Department dep)
                {
                    _depKeys.Add(dep.Id, dep.Name.Trim());
                    dep_comboBox.Items.Add(dep.Name.Trim());
                });
            }
        }

        private void FillPosition()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var q = from pos in context.Positions.AsNoTracking()
                        orderby pos.Name
                        select pos;

                var posList = q.ToList();

                pos_comboBox.Items.Clear();
                _positionKeys.Clear();

                posList.ForEach(delegate (Position pos)
                {
                    _positionKeys.Add(pos.Id, pos.Name.Trim());
                    pos_comboBox.Items.Add(pos.Name.Trim());
                });
            }
        }

        private void SetComboValues()
        {
            dep_comboBox.SelectedItem = _depKeys[_key.Department];
            pos_comboBox.SelectedItem = _positionKeys[_key.Position];
        }

        private void FillForm()
        {
            FillDepartment();
            FillPosition();

            if (_key is not null)
            {
                SetComboValues();

                using (LeanSiContext context = new LeanSiContext())
                {
                    var q = from authors in context.Authors.AsNoTracking()
                            where authors.Department == _key.Department
                            where authors.Position == _key.Position
                            select authors;

                    var author = q.FirstOrDefault();

                    name_textBox.Text = author.FirstName;
                    lastName_textBox.Text = author.LastName;
                }
            }
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                int depKey = _depKeys.Where(x => x.Value == dep_comboBox.Text).FirstOrDefault().Key;
                int posKey = _positionKeys.Where(x => x.Value == pos_comboBox.Text).FirstOrDefault().Key;

                if (_key is not null)
                {
                    var author = context.Authors.AsNoTracking()
                        .Where(x =>
                            x.FirstName == name_textBox.Text
                            && x.LastName == lastName_textBox.Text
                            && x.Department == _key.Department
                            && x.Position == _key.Position
                        ).FirstOrDefault();

                    context.Remove(author);
                    context.SaveChanges();
                }

                var au = new Author
                {
                    FirstName = name_textBox.Text,
                    LastName = lastName_textBox.Text,
                    Department = depKey,
                    Position = posKey
                };

                context.Authors.Add(au);
                context.SaveChanges();
                MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                }
            }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
