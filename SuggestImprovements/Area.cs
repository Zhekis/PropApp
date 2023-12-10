using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace SuggestImprovements;

public partial class Area
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ProposalKeys> Proposals { get; set; } = new List<ProposalKeys>();

    static NpgsqlDataAdapter adapter = null;
    static public DataTable dtArea = new DataTable();

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
