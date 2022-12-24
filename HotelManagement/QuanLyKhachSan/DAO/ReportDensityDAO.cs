using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ReportDensityDAO
    {
        private static ReportDensityDAO _instance;

        public static ReportDensityDAO Instance
        {
            get { if (_instance == null) _instance = new ReportDensityDAO(); return _instance; }
            private set => _instance = value;
        }

        public DataTable MakeReportDensityDAO(int month, int year)
        {
            var data = DataProvider.Instance.ExecuteQuery("proc_TinhMatDoSuDungPhong @month , @year", new object[] { month, year });
            return data;
        }
    }
}
