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
    public class ManagerBUS
    {
        public static ManagerDTO LoadInformation(AccountDTO account)
        {
            DataTable data = ManagerDAO.Instance.LoadInformationDAO(account.MaTK);
            DataRow row = data.Rows[0];
            ManagerDTO managerDTO = new ManagerDTO(row);

            return managerDTO;
        }

        public static int UpdateInformation(string MaQL, string HoTen, string DiaChi, string CCCD, string DienThoai)
        {
            return ManagerDAO.Instance.UpdateInformationDAO(MaQL, HoTen, DiaChi, CCCD, DienThoai);
        }
    }
}
