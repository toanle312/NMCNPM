using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    internal class HoaDon
    {
        private string mahd;
        private string ten;
        private string cMND;
        private string ngay;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Ten { get => ten; set => ten = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string Ngay { get => ngay; set => ngay = value; }
      

        public HoaDon(DataRow row)
        {
            this.Mahd = row["MaHD"].ToString();
            this.Ten = row["HoTen"].ToString();
            this.Ngay = row["Ngay"].ToString();
            this.CMND = row["CMND"].ToString();
           
        }
        public HoaDon() { }
    }
}
