using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportRevenueDTO
    {
        #region Properties
        private int _thang;
        private int _nam;
        private string _loaiPhong;
        private string _doanhThu;
        private string _tiLe;

        public int Thang { get { return _thang; } set { _thang = value; } }
        public int Nam { get { return _nam; } set { _nam = value; } }
        public string LoaiPhong { get { return _loaiPhong; } set {_loaiPhong = value; } }
        public string DoanhThu { get { return _doanhThu; } set { _doanhThu = value; } }
        public string TiLe { get { return _tiLe; } set { _tiLe = value; } }
        #endregion

        #region Constructor
        public ReportRevenueDTO() { }

        public ReportRevenueDTO(int thang, int nam, string loaiPhong, string doanhThu, string tiLe)
        {
            _thang = thang;
            _nam = nam;
            _loaiPhong = loaiPhong;
            _doanhThu = doanhThu;
            _tiLe = tiLe;   
        }

        public ReportRevenueDTO(DataRow row)
        {
            _thang = Int32.Parse(row["Thang"].ToString());
            _nam = Int32.Parse(row["Nam"].ToString());
            _loaiPhong = row["LoaiPhong"].ToString();
            _doanhThu = row["DoanhThu"].ToString();
            _tiLe = row["TiLe"].ToString();
        }


        #endregion
    }
}
