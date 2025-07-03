using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace Tetris_Game
{
    internal class DatabaseManager
    {
        private readonly string connectionString;

        public DatabaseManager()
        {
            connectionString = ConfigurationManager.ConnectionStrings["TetrisGame"].ConnectionString;
        }

        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);

            var adapter = new SqlDataAdapter(cmd);
            var dataTable = new DataTable();
            adapter.Fill(dataTable);

            return dataTable;
        }

        public void ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using var conn = new SqlConnection(connectionString);
            using var cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
        }
    }
}
