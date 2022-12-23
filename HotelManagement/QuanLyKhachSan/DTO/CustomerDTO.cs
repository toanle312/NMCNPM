using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        #region Properties
        private string cmnd;
        private string hoten;
        private string quoctich;
        private string diachi;
        private string dienthoai;
        public string Cmnd { get => cmnd; set { cmnd = value; } }
        public string Hoten { get => hoten; set { hoten = value; } }
        public string Quoctich { get => quoctich; set { quoctich = value; } }
        public string Diachi { get => diachi; set { diachi = value; } }
        public string Dienthoai { get => dienthoai; set { dienthoai =value; } }
        #endregion

        #region Constructor
        public CustomerDTO() 
        { 

        }

       public CustomerDTO(string cmnd, string hoten, string quoctich, string diachi, string dienthoai)
        {
            Cmnd = cmnd;
            Hoten = hoten;
            Quoctich = quoctich;
            Diachi = diachi;
            Dienthoai = dienthoai;   
        }

        public CustomerDTO(DataRow row)
        {
            Cmnd = row["CMND"].ToString();
            Hoten = row["HoTen"].ToString();
            Diachi = row["DiaChi"].ToString();
            Quoctich = row["QuocTich"].ToString();
            Dienthoai = row["DienThoai"].ToString();
        }


        #endregion

    }
}
