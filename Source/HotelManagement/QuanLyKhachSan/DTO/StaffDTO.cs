using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffDTO
    {
        #region Properties
        private string _maTK;
        private string _gioiTinh;
        private string _cccd;
        private string _hoTen;
        private string _diaChi;
        private string _dienThoai;
        private string _maNV;


        public string MaNV { get { return _maNV; } set { _maNV = value; } }
        public string MaTK { get { return _maTK; } set { _maTK = value; } }

        public string GioiTinh { get { return _gioiTinh; } set { _gioiTinh = value; } }

        public string CCCD { get { return _cccd; } set { _cccd = value; } }

        public string HoTen { get { return _hoTen; } set { _hoTen = value; } }

        public string DiaChi { get { return _diaChi; } set { _diaChi = value; } }

        public string DienThoai { get { return _dienThoai; } set { _dienThoai = value; } }

        #endregion

        #region Constructor
        public StaffDTO()
        {

        }

        public StaffDTO(string maNV, string maTK, string gioiTinh, string CCCD, string hoTen, string diaChi, string dienThoai)
        {
            _maTK = maTK;
            _gioiTinh = gioiTinh;
            _dienThoai = dienThoai;
            _hoTen = hoTen;
            _cccd = CCCD;
            _diaChi = diaChi;
            _maNV = maNV;
        }

        public StaffDTO(DataRow row)
        {
            _maTK = row["MaTK"].ToString();
            _gioiTinh = row["GioiTinh"].ToString(); ;
            _dienThoai = row["DienThoai"].ToString(); ;
            _hoTen = row["HoTen"].ToString(); ;
            _cccd = row["CMND/CCCD"].ToString(); ;
            _diaChi = row["DiaChi"].ToString(); ;
            _maNV = row["MaNV"].ToString(); ;
        }

        #endregion
    }
}