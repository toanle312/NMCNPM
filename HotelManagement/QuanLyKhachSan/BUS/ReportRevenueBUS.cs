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
    public class ReportRevenueBUS
    {
        public static List<ReportRevenueDTO> LoadReportRevenue(int month, int year)
        {
            DataTable data = ReportRevenueDAO.Instance.MakeReportRevenueDAO(month, year);

            List<ReportRevenueDTO> report = new List<ReportRevenueDTO>();

            foreach (DataRow item in data.Rows)
            {
                ReportRevenueDTO detail = new ReportRevenueDTO(item);
                report.Add(detail);
            }
            return report;
        }
    }
}
