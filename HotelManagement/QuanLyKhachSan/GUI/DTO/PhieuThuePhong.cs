using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    internal class PhieuThuePhong
    {
        private string maphieu;
        private string cmnd;
        private string songuoi;
        private string ngoaiquoc;

        public string Maphieu { get => maphieu; set => maphieu = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Songuoi { get => songuoi; set => songuoi = value; }
        public string Ngoaiquoc { get => ngoaiquoc; set => ngoaiquoc = value; }
        public PhieuThuePhong(DataRow row)
        {
            Maphieu = row["MaPhieu"].ToString();
            Cmnd = row["CMND"].ToString();
            Songuoi = row["SoNguoi"].ToString();
            Ngoaiquoc = row["NgoaiQuoc"].ToString();

        }
    }
}
