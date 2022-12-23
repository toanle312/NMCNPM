using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fIStaff : Form
    {
        private string maNV;
        StaffDTO staff = new StaffDTO();
        public fIStaff(string maNV)
        {
            this.maNV = maNV;
            InitializeComponent();
            resetdata();
        }

        void resetdata()
        {
            DataTable data = MaStaffDAO.Instance.LoadInforByMaNV(maNV);
            DataRow row = data.Rows[0];
            staff = new StaffDTO(row);
            if (staff != null)
            {
                lbNV.Text = maNV.Trim();
                txbHT.Text = staff.HoTen.Trim();
                txbCMND.Text = staff.CCCD.Trim();
                txbGT.Text = staff.GioiTinh.Trim();
                txbDC.Text = staff.DiaChi.Trim();
                txbDT.Text = staff.DienThoai.Trim();
                lbTK.Text = staff.MaTK.Trim();
            }
    }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btbUP_Click(object sender, EventArgs e)
        {
            bool isFill = fInfor.CheckFillInText(new Control[] { txbHT, txbCMND, txbGT, txbDC, txbDT });
            if (!isFill)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbHT.Text == staff.HoTen.Trim() && txbCMND.Text == staff.CCCD.Trim() && txbGT.Text == staff.GioiTinh.Trim() && txbDC.Text == staff.DiaChi.Trim() && txbDT.Text == staff.DienThoai.Trim())
            {
                MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = MaStaffDAO.Instance.UpdateStaff(maNV, txbHT.Text, txbCMND.Text, txbGT.Text, txbDC.Text, txbDT.Text);

            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi câp nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btbDE_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + txbHT.Text.ToString() + " hay không ? ", "Xác nhận xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = MaStaffDAO.Instance.DeleteStaff(staff.MaNV.Trim(), staff.MaTK.Trim());
                if (count > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Lỗi xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    
}
