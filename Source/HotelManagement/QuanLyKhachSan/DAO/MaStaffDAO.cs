using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MaStaffDAO
    {
        private static MaStaffDAO _instance;
        public static MaStaffDAO Instance
        {
            get { if (_instance == null) _instance = new MaStaffDAO(); return _instance; }
            private set => _instance = value;
        }

        private MaStaffDAO() { }

        public List<StaffDTO> LoadFullStaff()
        {
            List<StaffDTO> listStaff = new List<StaffDTO>();
            string query = "GetFullStaff ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                StaffDTO list = new StaffDTO(item);
                listStaff.Add(list);
            }

            return listStaff;
        }

        public DataTable LoadInforByMaNV(string maNV)
        {
            string query = "GetInforByMaNV  @MaNV ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
            return data;
        }

        public int InsertStaff(string MaNV, string HoTen, string CMND, string GioiTinh, string DiaChi, string DienThoai, string MaTK, string MatKhau)
        {
            string query = "InsertStaff @MaNV , @HoTen , @CMND , @GioiTinh , @DiaChi , @DienThoai , @MaTK , @MatKhau";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaNV, HoTen, CMND, GioiTinh, DiaChi, DienThoai, MaTK, MatKhau });
        }

        public int UpdateStaff(string MaNV, string HoTen, string CMND, string GioiTinh, string DiaChi, string DienThoai)
        {
            string query = "UpdateStaff @MaNV , @HoTen , @CMND , @GioiTinh , @DiaChi , @DienThoai ";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaNV, HoTen, CMND, GioiTinh, DiaChi, DienThoai });
        }

        public int DeleteStaff(string MaNV, string MaTK)
        {
            string query = "DeleteStaff  @MaNV , @MaTK ";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaNV, MaTK });
        }
    }
}
