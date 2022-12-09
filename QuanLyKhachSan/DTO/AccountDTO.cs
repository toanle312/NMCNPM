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
            this._maTK = userName;
            this._matKhau = passWord;
            this._email = email;
         }
        public AccountDTO(DataRow row)
        {
            this._maTK = row["MaTK"].ToString();

            this._matKhau = row["MatKhau"].ToString();

            this._email = row["EmailXacNhan"].ToString();
        }
        #endregion
    }
}
