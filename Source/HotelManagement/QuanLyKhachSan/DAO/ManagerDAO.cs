using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ManagerDAO
    {
        private static ManagerDAO _instance;

        public static ManagerDAO Instance
        {
            get { if (_instance == null) _instance = new ManagerDAO(); return _instance; }
            private set => _instance = value;
        }
        public DataTable LoadInformationDAO(string MaTK)
        {
            string query = "proc_load_info_admin @MaTK";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { MaTK });
            return data;
        }

        public int UpdateInformationDAO(string MaQL, string HoTen, string DiaChi, string CCCD, string DienThoai)
        {
            string query = "proc_update_info_admin @MaNV , @HoTen , @DiaChi , @CCCD , @DienThoai";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaQL, HoTen, DiaChi, CCCD, DienThoai });

        }
    }
}
