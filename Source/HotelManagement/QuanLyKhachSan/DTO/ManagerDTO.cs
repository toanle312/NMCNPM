using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ManagerDTO
    {
        #region Properties
        private string _maTK;
        private string _gioiTinh;
        private string _cccd;
        private string _hoTen;
        private string _diaChi;
        private string _dienThoai;
        private string _maQL;


        public string MaQL { get { return _maQL; } set { _maQL = value; } }
        public string MaTK { get { return _maTK; } set { _maTK = value; } }

        public string GioiTinh { get { return _gioiTinh; } set { _gioiTinh = value; } }

        public string CCCD { get { return _cccd; } set { _cccd = value; } }

        public string HoTen { get { return _hoTen; } set { _hoTen = value; } }

        public string DiaChi { get { return _diaChi; } set { _diaChi = value; } }

        public string DienThoai { get { return _dienThoai; } set { _dienThoai = value; } }

        #endregion

        #region Constructor
        public ManagerDTO()
        {

        }

        public ManagerDTO(string maQL, string maTK, string gioiTinh, string CCCD, string hoTen, string diaChi, string dienThoai)
        {
            this.MaTK = maTK;
            this.GioiTinh = gioiTinh;
            this.DienThoai = dienThoai;
            this.HoTen = hoTen;
            this.CCCD = CCCD;
            this.DiaChi = diaChi;
            this.MaQL = maQL;
        }

        public ManagerDTO(DataRow row)
        {
            this.MaTK = row["MaTK"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString(); ;
            this.DienThoai = row["DienThoai"].ToString(); ;
            this.HoTen = row["HoTen"].ToString(); ;
            this.CCCD = row["CMND/CCCD"].ToString(); ;
            this.DiaChi = row["DiaChi"].ToString(); ;
            this.MaQL = row["MaQL"].ToString(); ;
        }

        #endregion
    }
}
