using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomDTO
    {
        private string _maphong;
        private string _trangthai;
        private string _loaiphong;

        public string MaPhong { get { return _maphong; } set { _maphong = value; } }

        public string TrangThai { get { return _trangthai; } set { _trangthai = value; } }

        public string LoaiPhong { get { return _loaiphong; } set { _loaiphong = value; } }

        public RoomDTO()
        {

        }

        public RoomDTO(string maphong, string trangthai, string loaiphong)
        {
            this.MaPhong = maphong;
            this.TrangThai = trangthai;
            this.LoaiPhong = loaiphong;
        }

        public RoomDTO(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.LoaiPhong = row["LoaiPhong"].ToString();
        }

    }
}
