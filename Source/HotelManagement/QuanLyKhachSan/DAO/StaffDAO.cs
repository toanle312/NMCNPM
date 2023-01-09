using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StaffDAO
    {
        private static StaffDAO _instance;

        public static StaffDAO Instance
        {
            get { if (_instance == null) _instance = new StaffDAO(); return _instance; }
            private set => _instance = value;
        }
        public DataTable LoadInformationDAO(string MaTK)
        {
            string query = "proc_load_info @MaTK";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] {MaTK});
            return data;
        }

        public int UpdateInformationDAO(string MaNV, string HoTen, string DiaChi, string CCCD, string DienThoai)
        {
            string query = "proc_update_info @MaNV , @HoTen , @DiaChi , @CCCD , @DienThoai";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaNV, HoTen, DiaChi, CCCD, DienThoai });
           
        }
    }
}
