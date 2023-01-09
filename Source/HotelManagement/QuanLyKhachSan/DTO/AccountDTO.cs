using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        #region Properties
        private string _maTK;
        private string _matKhau;
        private string _email;

        public string MaTK { get { return _maTK; } set { _maTK = value; } }
        public string MatKhau { get { return _matKhau; } set { _matKhau = value; } }

        public string Email { get { return _email; } set { _email = value; } }
        #endregion 

        #region Constructor
        public AccountDTO() { }
        public AccountDTO(string userName, string passWord, string email)
        {
            this.MaTK = userName;
            this.MatKhau = passWord;
            this.Email = email;
         }
        public AccountDTO(DataRow row)
        {
            this.MaTK = row["MaTK"].ToString();

            this.MatKhau = row["MatKhau"].ToString();

            this.Email = row["EmailXacNhan"].ToString();
        }
        #endregion
    }
}
