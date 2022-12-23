using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        private static DataProvider _instance;
        private string _connectionStr = @"Data Source=LAPTOP-M3NT3CHJ\SQLEXPRESS;Initial Catalog=QLKHACHSAN;Integrated Security=True";
        private DataProvider() { }

        public SqlConnection connectSQL()
        {
            SqlConnection conn = new SqlConnection(_connectionStr);
            return conn;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            SqlConnection conn = connectSQL();

            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);
            AddParameter(query, parameter, command);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);

            conn.Close();

            return data;

        }

        public int ExecuteNoneQuery(string query, object[] parameter = null)
        {
            int data = 0;

            SqlConnection conn = connectSQL();

            conn.Open();

            SqlCommand command = new SqlCommand(query, conn);
            AddParameter(query, parameter, command);
            data = command.ExecuteNonQuery();

            conn.Close();

            return data;

        }


        private void AddParameter(string query, object[] parameter, SqlCommand command)
        {
            if (parameter != null)
            {
                string[] listParameter = query.Split(' ');
                int i = 0;
                foreach (string item in listParameter)
                {
                    if (item.Contains("@"))
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        ++i;
                    }
                }
            }
        }

        public static DataProvider Instance
        {
            get { if (_instance == null) _instance = new DataProvider(); return _instance; }
            private set => _instance = value;
        }
    }
}
