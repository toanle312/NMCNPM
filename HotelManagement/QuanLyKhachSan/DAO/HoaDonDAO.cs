using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class HoaDonDAO
    { 
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new HoaDonDAO();
                return HoaDonDAO.instance;
            }
            private set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO() { }
        public List<HoaDon> get_list_HoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "exec sp_Ds_HoaDonPhong";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon(dr);
                list.Add(hoaDon);
            }
            return list;
        }
        public List<HoaDon> get_list_HoaDon_chuathanhtoan()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "sp_ds_hoadonphong_chuathanhtoan";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                HoaDon hoaDon = new HoaDon(dr);
                list.Add(hoaDon);
            }
            return list;
        }
        public List<ChiTietHoaDon> get_list_ChiTietHoaDonPhong(string mahd)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            string query = "exec sp_ChitietHoaDon '" + mahd + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(dr);
                list.Add((ChiTietHoaDon)chiTietHoaDon);
            }
            return list;
        }
        public List<ChiTietDichVu> get_list_ChiTietHoaDonDichVu(string mahd)
        {
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            string query = "exec sp_ChitietHoaDonDichVu '" + mahd + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                ChiTietDichVu chiTietHoaDon = new ChiTietDichVu(dr);
                list.Add((ChiTietDichVu)chiTietHoaDon);
            }
            return list;
        }
        public int delete_HoaDon(string mahd)
        {
            string query = "sp_xoahoadon '" + mahd + "'";
            return DataProvider.Instance.ExecuteNoneQuery(query);

        }
        public DataRow thanhtoan_hoadon(string cmnd)
        {
            string query = "sp_thanhtoanphong '" + cmnd + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
        public DataRow lap_phieuthuephong(string cmnd, string songuoi, string manv, string ngoaiquoc)
        {
            string query = "lap_phieuthuephong '" + cmnd + "','" + manv + "'," + songuoi + ",N'" + ngoaiquoc + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
        public DataRow tao_hoadon(string cmnd, string manv)
        {
            string query = "sp_taohoadon '" + cmnd + "','" + manv + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
        public DataRow themchitietphong(string maphong, string mahd, string maphieu)
        {
            string query = "sp_themchitietphong '" + maphong + "','" + mahd + "','" + maphieu + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
        public List<PhieuThuePhong> ds_phieuthuephong()
        {
            List<PhieuThuePhong> phieuThuePhongs = new List<PhieuThuePhong>();
            string query = "sp_ds_phieutrongngay";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PhieuThuePhong phieuThuePhong = new PhieuThuePhong(dr);
                phieuThuePhongs.Add(phieuThuePhong);
            }
            return phieuThuePhongs;
        }
        public void capnhathoadon(string mahd)
        {
            string query1 = "sp_capnhatthanhtien '" + mahd + "'";
            string query2 = "sp_capnhathoadon '" + mahd + "'";
            DataProvider.Instance.ExecuteNoneQuery(query1);
            DataProvider.Instance.ExecuteNoneQuery(query2);
        }
        public List<string> get_dsphongtrong()
        {
            List<string> strings = new List<string>();
            string query = "sp_danhsachphongtrong";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                strings.Add(r["MaPhong"].ToString());
            }
            return strings;
        }
    }
}
