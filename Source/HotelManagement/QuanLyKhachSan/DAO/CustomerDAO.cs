using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO _instance;   
        public static CustomerDAO Instance
        {
            get { if (_instance == null) _instance = new CustomerDAO(); return _instance; }
            private set => _instance = value;
        }

        private CustomerDAO() { }

        public List<CustomerDTO> LoadInformation() 
        { 
            List<CustomerDTO> listCustomer = new List<CustomerDTO>();
            string query = "GetFullCustomer ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow item in dataTable.Rows) 
            {
                CustomerDTO list  = new CustomerDTO(item);
                listCustomer.Add(list);
            }

            return listCustomer;
        }

        public DataTable LoadInforByCMND(string cmnd)
        {
            string query = "GetInforCusByCMND  @cmnd ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { cmnd });
            return data;
        }

        public int UpdateInforCustomer(string cmnd, string HoTen, string QuocTich, string DiaChi, string DienThoai)
        {
            string query = "UpdateInforCus @cmnd , @HoTen , @QuocTich , @DiaChi , @DienThoai";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { cmnd, HoTen, QuocTich, DiaChi, DienThoai });
        }

        public int InsertCustomer(string cmnd, string HoTen, string QuocTich, string DiaChi, string DienThoai)
        {
            string query = "InsertCustomer @cmnd , @HoTen , @QuocTich , @DiaChi , @DienThoai";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { cmnd, HoTen, QuocTich, DiaChi, DienThoai });
        }

        public int DeleteCustomer(string cmnd)
        {
            string query = "DeleteCustomer  @cmnd ";
            return DataProvider.Instance.ExecuteNoneQuery(query, new object[] { cmnd });
        }
    }
}
