using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO _instance;

        public static ServiceDAO Instance
        {
            get { if (_instance == null) _instance = new ServiceDAO(); return _instance; }
            private set => _instance = value;
        }

        public DataTable LoadServiceListDAO()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select TenDV, DonGia, GhiChu From DICHVU");
            return data;
        }

        public bool InsertFood(string name, SqlMoney price, string note)
        {
            try
            {
                string query = string.Format("Insert DICHVU (TenDV, DonGia, GhiChu) VALUES (N'{0}', {1}, N'{2}')", name, price, note);
                int result = DataProvider.Instance.ExecuteNoneQuery(query);
                return result > 0;

            }
            catch { }
            return false;
        }

        public bool UpdateFood(string name, SqlMoney price, string note)
        {
            try
            {
                string query = string.Format("Update DICHVU Set DonGia = {0}, GhiChu = N'{1}' Where TenDV = N'{2}'", price, note, name);
                int result = DataProvider.Instance.ExecuteNoneQuery(query);
                return result > 0;
            }
            catch { }

            return false;
        }

        public void detailDeleteServiceByName(string name)
        {
            string query = string.Format("delete CHITIETHOADONDICHVU where TenDV = N'{0}'", name);
            DataProvider.Instance.ExecuteQuery(query);
            string query1 = "Update HOADON set DonGiaDichVu = 0 where MaHD NOT IN(Select MaHD from CHITIETHOADONDICHVU)";
            DataProvider.Instance.ExecuteQuery(query1);
            string query2 = "Update HOADON set TONGTIEN = DonGiaDichVu + DonGiaPhong";
            DataProvider.Instance.ExecuteQuery(query2);
        }

        public bool DeleteService(string name)
        {
            try
            {
                detailDeleteServiceByName(name);
                string query = string.Format("Delete DICHVU where TenDV = N'{0}'", name);
                int result = DataProvider.Instance.ExecuteNoneQuery(query);
                return result > 0;
            }
            catch { }

            return false;
        }

    }
}
