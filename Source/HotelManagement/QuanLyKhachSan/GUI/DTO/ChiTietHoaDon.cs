using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    internal class ChiTietHoaDon
    {
        private string phong;
        private string dongia;
        private string songay;
        private int songuoi;
        private string ngoaiquoc;

        public string Phong { get => phong; set => phong = value; }
        public string Dongia { get => dongia; set => dongia = value; }
        public string Songay { get => songay; set => songay = value; }
        public string Ngoaiquoc { get => ngoaiquoc; set => ngoaiquoc = value; }
        public int Songuoi { get => songuoi; set => songuoi = value; }

        public ChiTietHoaDon(DataRow row)
        {
            Phong = row["MaPhong"].ToString();
            Dongia = row["DonGia"].ToString();
            Songay = row["SoNgay"].ToString();
            Songuoi = int.Parse(row["SoNguoi"].ToString());
            Ngoaiquoc = row["NgoaiQuoc"].ToString();
        }
    }
}
