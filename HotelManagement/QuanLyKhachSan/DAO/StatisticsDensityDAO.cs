using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StatisticsDensityDAO
    {
        private static StatisticsDensityDAO _instance;
        public static StatisticsDensityDAO Instance
        {
            get { if (_instance == null) _instance = new StatisticsDensityDAO(); return _instance; }
            private set => _instance = value;
        }

        public DataTable MakeStatisticsDensityDAO(int month, int year)
        {
            var data = DataProvider.Instance.ExecuteQuery("proc_TinhMatDoSuDungPhong @month , @year", new object[] { month, year });
            return data;
        }
    }
}
