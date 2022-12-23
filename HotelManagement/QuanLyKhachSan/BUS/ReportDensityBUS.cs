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
    public class ReportDensityBUS
    {
        public static List<ReportDensityDTO> LoadReportDensity(int month, int year)
        {
            DataTable data = ReportDensityDAO.Instance.MakeReportDensityDAO(month, year);

            List<ReportDensityDTO> report = new List<ReportDensityDTO>();

            foreach (DataRow item in data.Rows)
            {
                ReportDensityDTO detail = new ReportDensityDTO(item);
                report.Add(detail);
            }

            return report;
        }
    }
}
