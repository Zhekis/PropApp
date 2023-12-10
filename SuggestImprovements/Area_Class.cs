using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuggestImprovements
{
    internal class Area_Class
    {
        static NpgsqlDataAdapter adapter = null;
        static DataTable dtArea = new DataTable();

        static public void GetArea()
        {
            try
            {
                DataBase db = new DataBase();
                adapter = new NpgsqlDataAdapter("SELECT * FROM public.\"Areas\";", db.GetConnection());
                dtArea.Clear();
                adapter.Fill(dtArea);
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
