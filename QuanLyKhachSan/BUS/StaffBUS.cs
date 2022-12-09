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
    public class StaffBUS
    {
        public static StaffDTO LoadInformation(AccountDTO account)
        {
            DataTable data = StaffDAO.Instance.LoadInformationDAO(account.MaTK);
            DataRow row = data.Rows[0];
            StaffDTO staffDTO = new StaffDTO(row);

            return staffDTO;
        }

        public static int UpdateInformation(string MaNV, string HoTen, string DiaChi, string CCCD, string DienThoai)
        {
            return StaffDAO.Instance.UpdateInformationDAO(MaNV, HoTen, DiaChi, CCCD, DienThoai);
        }
    }
}
