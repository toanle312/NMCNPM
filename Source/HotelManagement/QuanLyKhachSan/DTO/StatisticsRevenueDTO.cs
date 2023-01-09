using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StatisticsRevenueDTO
    {
        #region Properties
        private int _thang;
        private int _nam;


        public int Thang { get { return _thang; } set { _thang = value; } }
        public int Nam { get { return _nam; } set { _nam = value; } }

        #endregion

        #region Constructor
        public StatisticsRevenueDTO() { }

        public StatisticsRevenueDTO(int thang, int nam, string phong, string soNgayThue, string tiLe)
        {
            this._thang = thang;
            this._nam = nam;
        }

        public StatisticsRevenueDTO(DataRow row)
        {
            this._thang = Int32.Parse(row["Thang"].ToString());
            this._nam = Int32.Parse(row["Nam"].ToString());

        }


        #endregion
    }
}
