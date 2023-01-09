using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Security.Cryptography;

namespace BUS
{
    public class AccountBUS
    {
        public static string CheckLogin(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hashPass = "";

            foreach(byte item in hashData)
            {
                hashPass += item.ToString("x2");
            }

            DataTable data = AccountDAO.Instance.CheckLoginDAO(username, hashPass);

            if(data.Rows.Count > 0)
            {
                if(username.Contains("admin"))
                {
                    return "admin";
                }  
                else if(username.Contains("staff"))
                {
                    return "staff";
                }    
            }    

            return "error";
        }

        public static AccountDTO GetAccountFromID(string username)
        {
            DataTable data = AccountDAO.Instance.GetAccountFromIDDAO(username);
            DataRow row = data.Rows[0];
            AccountDTO accountDTO = new AccountDTO(row);

            return accountDTO;
        }
    }
}
