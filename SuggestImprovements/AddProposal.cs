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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SuggestImprovements
{
    public partial class AddProposal : Form
    {
        private ProposalKeys? _key;
        private IDictionary<int, string> _authorKeys;
        private IDictionary<int, string> _areaKeys;
        private IDictionary<int, string> _lossKeys;
        private IDictionary<int, string> _judgKeys;

        public AddProposal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _key = null;
            _authorKeys = new Dictionary<int, string>();
            _areaKeys = new Dictionary<int, string>();
            _lossKeys = new Dictionary<int, string>();
            _judgKeys = new Dictionary<int, string>();
        }

        public AddProposal(ProposalKeys? key)
        { 
            InitializeComponent();
            _key = key;
            _authorKeys = new Dictionary<int, string>();
            _areaKeys = new Dictionary<int, string>();
            _lossKeys = new Dictionary<int, string>();
            _judgKeys = new Dictionary<int, string>();
        }

        private void FillJudgment()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var q = from judg in context.Judgments.AsNoTracking()
                        orderby judg.Name
                        select judg;

                var areasList = q.ToList();

                Judgment_cbx.Items.Clear();
                _judgKeys.Clear();

                areasList.ForEach(delegate (Judgment judg)
                {
                    _judgKeys.Add(judg.Id, judg.Name.Trim());
                    Judgment_cbx.Items.Add(judg.Name.Trim());
                });
            }
        }

        private void FillAreas()
        {
            using(LeanSiContext context = new LeanSiContext())
            {
                var q = from areas in context.Areas.AsNoTracking()
                        orderby areas.Name
                        select areas;

                var areasList = q.ToList();

                Area_cbx.Items.Clear();
                _areaKeys.Clear();

                areasList.ForEach(delegate (Area area)
                {
                    _areaKeys.Add(area.Id, area.Name.Trim());
                    Area_cbx.Items.Add(area.Name.Trim());
                });
            }
        }

        private void FillLoss()
        {
            using (LeanSiContext context = new LeanSiContext())
            {
                var q = from losses in context.Losses.AsNoTracking()
                        orderby losses.Name
                        select losses;

                var areasList = q.ToList();

                Loss_cbx.Items.Clear();
                _lossKeys.Clear();

                areasList.ForEach(delegate (Loss loss)
                {
                    _lossKeys.Add(loss.Id, loss.Name.Trim());
                    Loss_cbx.Items.Add(loss.Name.Trim());
                });
            }
        }

        private void FillAuthors()
        {
            using (var context = new LeanSiContext())
            {
                var q = from authors in context.Authors.AsNoTracking()
                        orderby authors.FirstName
                        select authors;

                var authorList = q.ToList();

                Author_cbx.Items.Clear();
                _authorKeys.Clear();

                authorList.ForEach(delegate (Author author)
                {
                    _authorKeys.Add(author.Id, author.FirstName + " " + author.LastName.Trim());
                    Author_cbx.Items.Add(author.FirstName + " " + author.LastName.Trim());
                });
            }
        }

        private void SetComboValues()
        {
            Author_cbx.SelectedItem = _authorKeys[_key.Author];
            Area_cbx.SelectedItem = _areaKeys[_key.Area];
            Loss_cbx.SelectedItem = _lossKeys[_key.Loss];
            Judgment_cbx.SelectedItem = _judgKeys[_key.Judgment];
        }

        private void FillForm()
        {
            FillAuthors();
            FillAreas();
            FillLoss();
            FillJudgment();

            if(_key is not null)
            {
                SetComboValues();

                using(LeanSiContext context = new LeanSiContext())
                {
                    var q = from proposal in context.Proposals.AsNoTracking()
                            where proposal.Area == _key.Area
                            where proposal.Loss == _key.Loss
                            where proposal.Judgment == _key.Judgment
                            select proposal;

                    var prop = q.FirstOrDefault();

                    dateTimePicker1.Value = new DateTime(prop.Date.Year, prop.Date.Month, prop.Date.Day);
                    Number_textBox.Text = prop.Number.ToString();
                    Description_textbx.Text = prop.Description;
                    Cost_textbx.Text = prop.Costs.ToString();
                    ActCost_textbx.Text = prop.ActualCosts.ToString();
                    Economic_textbx.Text = prop.EconomicEffect.ToString();
                    checkBox1.Checked = prop.IsCompleted;

                    DateOnly? dateComplete = prop.DateComplete;

                    if (prop.IsCompleted)
                    {
                        if (dateComplete == null)
                            dateTimePicker2.Value = new DateTime(prop.Date.Year, prop.Date.Month, prop.Date.Day);
                        else
                        {
                            DateOnly date = (DateOnly)prop.DateComplete;
                            dateTimePicker2.Value = new DateTime(date.Year, date.Month, date.Day);
                        }

                    }
                    else
                    {
                        dateTimePicker2.Visible = false;
                        label3.Visible = false;
                    }
                }
            }
        }

        private void AddPosition_Load(object sender, EventArgs e)
        {
            FillForm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker2.Visible = true;
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
                dateTimePicker2.Visible = false;
            }

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            using(LeanSiContext context = new LeanSiContext())
            {
                int authorKey = _authorKeys.Where(x => x.Value == Author_cbx.Text).FirstOrDefault().Key;
                int areaKey = _areaKeys.Where(x => x.Value == Area_cbx.Text).FirstOrDefault().Key;
                int lossKey = _lossKeys.Where(x => x.Value == Loss_cbx.Text).FirstOrDefault().Key;
                int judgKey = _judgKeys.Where(x => x.Value == Judgment_cbx.Text).FirstOrDefault().Key;

                if (_key is not null)
                {
                    var proposal = context.Proposals.AsNoTracking()
                        .Where(x =>
                            x.Author == _key.Author
                            && x.Area == _key.Area
                            && x.Loss == _key.Loss
                            && x.Judgment == _key.Judgment
                        ).FirstOrDefault();

                    context.Remove(proposal);
                    context.SaveChanges();
                    //MessageBox.Show("Запись Удалена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DateOnly? date = null;

                    if (checkBox1.Checked)
                    {
                        date = DateTimeExtensions.DateOnlyFromDateTime(dateTimePicker2.Value);
                    }

                    var prop = new ProposalKeys
                    {
                        Number = Convert.ToInt32(Number_textBox.Text),
                        Date = DateTimeExtensions.DateOnlyFromDateTime(dateTimePicker1.Value),
                        Author = authorKey,
                        Area = areaKey,
                        Loss = lossKey,
                        Judgment = judgKey,
                        Description = Description_textbx.Text.ToString(),
                        Costs = GetInt(Cost_textbx.Text),
                        EconomicEffect = GetInt(Economic_textbx.Text),
                        ActualCosts = GetInt(ActCost_textbx.Text),
                        IsCompleted = checkBox1.Checked,
                        DateComplete = date
                    };

                    context.Proposals.Add(prop);
                    context.SaveChanges();
                    MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    DateOnly? date = null;

                    if (checkBox1.Checked)
                    {
                        date = DateTimeExtensions.DateOnlyFromDateTime(dateTimePicker2.Value);
                    }

                    var prop = new ProposalKeys
                    {
                        Date = DateTimeExtensions.DateOnlyFromDateTime(dateTimePicker1.Value),
                        Author = authorKey,
                        Area = areaKey,
                        Loss = lossKey,
                        Judgment = judgKey,
                        Description = Description_textbx.Text.ToString(),
                        Costs = GetInt(Cost_textbx.Text),
                        EconomicEffect = GetInt(Economic_textbx.Text),
                        ActualCosts = GetInt(ActCost_textbx.Text),
                        IsCompleted = checkBox1.Checked,
                        DateComplete = date
                    };

                    context.Proposals.Add(prop);
                    context.SaveChanges();
                    MessageBox.Show("Запись добавлена", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private int? GetInt(string text)
        {
            if (text == "")
                return null;

            return Convert.ToInt32(text);
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cost_textbx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Cost_textbx.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Cost_textbx.Text = Cost_textbx.Text.Remove(Cost_textbx.Text.Length - 1);
            }
        }

        private void Economic_textbx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Economic_textbx.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                Economic_textbx.Text = Economic_textbx.Text.Remove(Economic_textbx.Text.Length - 1);
            }
        }

        private void ActCost_textbx_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ActCost_textbx.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                ActCost_textbx.Text = ActCost_textbx.Text.Remove(ActCost_textbx.Text.Length - 1);
            }
        }
    }
}
