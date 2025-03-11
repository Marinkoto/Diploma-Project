using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma_Project
{
    public class DatabaseHelper
    {
        private string connString;

        public DatabaseHelper()
        {
            if (string.IsNullOrEmpty(connString))
            {
                var setting = ConfigurationManager.ConnectionStrings["Database"];
                this.connString = setting.ConnectionString;
            }
        }
        public DataTable ExecuteQuery(string query,params OleDbParameter[] parameters) 
        {
            using(OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if(parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        public int ExecuteNonQuery(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
            }
        }   
    }
}
