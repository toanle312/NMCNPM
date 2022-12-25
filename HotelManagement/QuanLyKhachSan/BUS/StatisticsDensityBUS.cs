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
    public class StatisticsDensityBUS
    {
        public static List<StatisticsDensityDTO> LoadStatisticsDensity(int month, int year)
        {
            DataTable data = StatisticsDensityDAO.Instance.MakeStatisticsDensityDAO(month, year);

            List<StatisticsDensityDTO> report = new List<StatisticsDensityDTO>();

            foreach (DataRow item in data.Rows)
            {
                StatisticsDensityDTO detail = new StatisticsDensityDTO(item);
                report.Add(detail);
            }
            return report;
        }
    }
}
