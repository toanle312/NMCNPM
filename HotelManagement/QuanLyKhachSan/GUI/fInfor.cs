using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class fInfor : Form
    {
        StaffDTO staff = new StaffDTO();
        AccountDTO setAccount = new AccountDTO();

        public void resetData(AccountDTO acc, StaffDTO stff)
        {
            if (stff != null)
            {
                nameTXB.Text = stff.HoTen.Trim();
                addressTXB.Text = stff.DiaChi.Trim();
                contactTXB.Text = stff.DienThoai.Trim();
                idTXB.Text = stff.CCCD.Trim();
                sex.Text = staff.GioiTinh.Trim();
                email.Text = acc.Email.Trim();
                idStaff.Text = stff.MaNV.Trim();
            }
        }
        public fInfor(AccountDTO account)
        {
            InitializeComponent();
            staff = StaffBUS.LoadInformation(account);
            resetData(account, staff);
            setAccount = account;
        }

        public static bool CheckFillInText(Control[] controls)
        {
            foreach (var control in controls)
            {
                if (control.Text == string.Empty)
                    return false;
            }
            return true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void fInfor_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        { 
            bool isFill = CheckFillInText(new Control[] { nameTXB, addressTXB, idTXB, contactTXB });
            if(!isFill)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(idStaff.Text == staff.MaNV.Trim() && nameTXB.Text == staff.HoTen.Trim() && addressTXB.Text == staff.DiaChi.Trim() && idTXB.Text == staff.CCCD.Trim() && contactTXB.Text == staff.DienThoai.Trim())
            {
                MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            int count = StaffBUS.UpdateInformation(idStaff.Text, nameTXB.Text, addressTXB.Text, idTXB.Text, contactTXB.Text);
            MessageBox.Show("Cập nhật thông tin thành công");

            staff = StaffBUS.LoadInformation(setAccount);

            resetData(setAccount, staff);
        }

        private void addressTXB_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
