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
    public partial class fInforAdmin : Form
    {
        ManagerDTO manager = new ManagerDTO();
        AccountDTO setAccount = new AccountDTO();

        public void resetData(AccountDTO acc, ManagerDTO mnger)
        {
            if (mnger != null)
            {
                nameTXB.Text = mnger.HoTen.Trim();
                addressTXB.Text = mnger.DiaChi.Trim();
                contactTXB.Text = mnger.DienThoai.Trim();
                idTXB.Text = mnger.CCCD.Trim();
                sex.Text = manager.GioiTinh.Trim();
                email.Text = acc.Email.Trim();
                idManager.Text = mnger.MaQL.Trim();
            }
        }
        public fInforAdmin(AccountDTO account)
        {
            InitializeComponent();
            manager = ManagerBUS.LoadInformation(account);
            resetData(account, manager);
            setAccount = account;
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

            bool isFill = fInfor.CheckFillInText(new Control[] { nameTXB, addressTXB, idTXB, contactTXB });
            if(!isFill)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(idManager.Text == manager.MaQL.Trim() && nameTXB.Text == manager.HoTen.Trim() && addressTXB.Text == manager.DiaChi.Trim() && idTXB.Text == manager.CCCD.Trim() && contactTXB.Text == manager.DienThoai.Trim())
            {
                MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            int count = ManagerBUS.UpdateInformation(idManager.Text, nameTXB.Text, addressTXB.Text, idTXB.Text, contactTXB.Text);
            MessageBox.Show("Cập nhật thông tin thành công");

            manager = ManagerBUS.LoadInformation(setAccount);

            resetData(setAccount, manager);
        }

        private void addressTXB_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
