using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ServiceDTO
    {
        #region Properties
        private string _tenDV;
        private string _donGia;
        private string _ghiChu;

        public string TenDV { get { return _tenDV; } set { _tenDV = value; } }

        public string DonGia { get { return _donGia; } set { _donGia = value; } }

        public string GhiChu { get { return _ghiChu; } set { _ghiChu = value; } }
        #endregion

        #region Constructor
        public ServiceDTO() { }

        public ServiceDTO(string tenDV, string donGia, string ghiChu)
        {
            _tenDV = tenDV;
            _donGia = donGia;
            _ghiChu = ghiChu;
        }

        public ServiceDTO(DataRow row)
        {
            _tenDV = row["TenDV"].ToString();
            _donGia = row["DonGia"].ToString();
            _ghiChu = row["GhiChu"].ToString();
        }

        #endregion

    }
}
