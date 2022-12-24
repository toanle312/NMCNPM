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
    public class ServiceBUS
    {
        public static List<ServiceDTO> LoadServiceList()
        {
            DataTable data = ServiceDAO.Instance.LoadServiceListDAO();

            List<ServiceDTO> serviceList = new List<ServiceDTO>();

            foreach (DataRow item in data.Rows)
            {
                ServiceDTO service = new ServiceDTO(item);
                serviceList.Add(service);
            }

            return serviceList;
        }
    }
}
