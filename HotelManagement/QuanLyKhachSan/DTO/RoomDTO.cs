using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoomDTO
    {
        #region Properties
        private string _maPhong;
        private string _tinhTrang;
        private string _loaiPhong;

        public string MaPhong { get { return _maPhong; } set { _maPhong = value; } }
        public string TinhTrang { get { return _tinhTrang; } set { _tinhTrang = value; } }
        public string LoaiPhong { get { return _loaiPhong; } set { _loaiPhong = value; } }
        #endregion

        #region Contructors
        public RoomDTO() { }
        public RoomDTO(string maPhong, string tinhTrang, string loaiPhong)
        {
            this._maPhong = maPhong;
            this._tinhTrang = tinhTrang;
            this._loaiPhong = loaiPhong;
        }
        public RoomDTO(DataRow row)
        {
            this._maPhong = row["MaPhong"].ToString();

            this._tinhTrang = row["TrangThai"].ToString();

            this._loaiPhong = row["LoaiPhong"].ToString();
        }
        #endregion
    }
}
