using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO _instance;

        public static AccountDAO Instance
        {
            get { if (_instance == null) _instance = new AccountDAO(); return _instance; }
            private set => _instance = value;
        }
        public DataTable CheckLoginDAO(string username, string password)
        {
            string query = "proc_login @user , @pass";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });

            return data;
        }
        public DataTable GetAccountFromIDDAO(string username)
        {
            string query = "proc_get_account @user";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            return data;
        }

    }
}
