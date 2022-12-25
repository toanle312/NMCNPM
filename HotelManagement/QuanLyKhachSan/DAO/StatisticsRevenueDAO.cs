using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StatisticsRevenueDAO
    {
        private static StatisticsRevenueDAO _instance;

        public static StatisticsRevenueDAO Instance
        {
            get { if (_instance == null) _instance = new StatisticsRevenueDAO(); return _instance; }
            private set => _instance = value;
        }

        public DataTable MakeStatisticsRevenueDAO(int month, int year)
        {
            var data = DataProvider.Instance.ExecuteQuery("proc_TinhDoanhThuTheoLoaiPhong @month , @year", new object[] { month, year });
            return data;
        }
    }
}
