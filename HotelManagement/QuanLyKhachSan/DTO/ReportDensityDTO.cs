using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ReportDensityDTO
    {
        #region Properties
        private int _thang;
        private int _nam;
        private string _phong;
        private string _soNgayThue;
        private string _tiLe;

        public int Thang { get { return _thang; } set { _thang = value; } }
        public int Nam { get { return _nam; } set { _nam = value; } }
        public string Phong { get { return _phong; } set { _phong = value; } }
        public string SoNgayThue { get { return _soNgayThue; } set { _soNgayThue = value; } }
        public string TiLe { get { return _tiLe; } set { _tiLe = value; } }
        #endregion

        #region Constructor
        public ReportDensityDTO() { }

        public ReportDensityDTO(int thang, int nam, string phong, string soNgayThue, string tiLe)
        {
            _thang = thang;
            _nam = nam;
            _phong = phong;
            _soNgayThue = soNgayThue;
            _tiLe = tiLe;   
        }

        public ReportDensityDTO(DataRow row)
        {
            _thang = Int32.Parse(row["Thang"].ToString());
            _nam = Int32.Parse(row["Nam"].ToString());
            _phong = row["Phong"].ToString();
            _soNgayThue = row["SoNgayThue"].ToString();
            _tiLe = row["TiLe"].ToString();
        }


        #endregion
    }
}
