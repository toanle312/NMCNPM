using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyDinhDTO
    {
        private string loaiPhong;
        private string dongia;
        private string mota;

        public string LoaiPhong { get => loaiPhong; set { loaiPhong = value; } }
        public string Dongia { get => dongia; set { dongia = value; } }
        public string Mota { get => mota; set { mota = value; } }

        #region Constructor
        public QuyDinhDTO() { }

        public QuyDinhDTO(string loaiPhong, string dongia, string mota)
        {
            LoaiPhong = loaiPhong;
            Dongia = dongia;
            Mota = mota;
        }
        

        public QuyDinhDTO(DataRow row)
        {
            LoaiPhong = row["LoaiPhong"].ToString();
            Dongia = row["DonGia"].ToString();
            Mota = row["MoTa"].ToString();
        }
        #endregion
    }
}
