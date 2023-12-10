using Microsoft.EntityFrameworkCore;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SuggestImprovements
{
    internal class DataBase
    {
        //private string CONN_STR = "Host=localhost;Port=5432;Database=LeanSI;Username=postgres;Password=acer";

        NpgsqlConnection conn = new NpgsqlConnection(@"Host=localhost;Port=5432;Database=LeanSI;Username=postgres;Password=acer");

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed) 
                conn.Open();
        }

        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public NpgsqlConnection GetConnection()
        {
            return conn;
        }
    }
}
