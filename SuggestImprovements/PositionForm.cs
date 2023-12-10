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
    public partial class PositionForm : Form
    {
        private NpgsqlDataAdapter adapter = null;
        DataTable dt;

        public PositionForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            adapter = new NpgsqlDataAdapter("SELECT * FROM public.\"Positions\";", db.GetConnection());
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
