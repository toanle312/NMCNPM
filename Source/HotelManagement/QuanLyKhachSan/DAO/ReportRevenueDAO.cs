using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReportRevenueDAO
    {
        private static ReportRevenueDAO _instance;

        public static ReportRevenueDAO Instance
        {
            get { if (_instance == null) _instance = new ReportRevenueDAO(); return _instance; }
            private set => _instance = value;
        }

        public DataTable MakeReportRevenueDAO(int month, int year)
        {
            var data = DataProvider.Instance.ExecuteQuery("proc_TinhDoanhThuTheoLoaiPhong @month , @year", new object[] { month, year });
            return data;
        }
    }
}
