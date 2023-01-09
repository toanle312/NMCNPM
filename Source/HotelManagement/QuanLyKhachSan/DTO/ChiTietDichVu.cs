using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDichVu
    {
        private string tenmon;
        private string soluong;
        private string thanhtien;

        public string Tenmon { get => tenmon; set => tenmon = value; }
        public string Soluong { get => soluong; set => soluong = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public ChiTietDichVu(DataRow row)
        {
            Tenmon = row["TenDV"].ToString();
            Soluong = row["Soluong"].ToString();
            Thanhtien = row["ThanhTien"].ToString();
        }
    }
}
