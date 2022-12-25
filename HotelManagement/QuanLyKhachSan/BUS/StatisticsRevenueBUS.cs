using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StatisticsRevenueBUS
    {
        public static List<StatisticsRevenueDTO> LoadStatisticsRevenue(int month, int year)
        {
            DataTable data = StatisticsRevenueDAO.Instance.MakeStatisticsRevenueDAO(month, year);

            List<StatisticsRevenueDTO> report = new List<StatisticsRevenueDTO>();

            foreach (DataRow item in data.Rows)
            {
                StatisticsRevenueDTO detail = new StatisticsRevenueDTO(item);
                report.Add(detail);
            }
            return report;
        }
    }
}
