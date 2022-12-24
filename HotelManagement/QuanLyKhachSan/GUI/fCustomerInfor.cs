using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class fCustomerInfor : Form
    {
        private string cmnd;
        CustomerDTO cus = new CustomerDTO();
        public fCustomerInfor(string cmnd)
        {
            this.cmnd = cmnd;
            InitializeComponent();
            resetdata();
        }

        void resetdata()
        {
            DataTable data = CustomerDAO.Instance.LoadInforByCMND(cmnd);
            DataRow row = data.Rows[0];
            cus = new CustomerDTO(row);
            if (cus != null)
            {
               txbCMND.Text = cus.Cmnd.Trim();
               txbHT.Text = cus.Hoten.Trim();
               txbQT.Text = cus.Quoctich.Trim();
               txbDC.Text = cus.Diachi.Trim();
               txbDT.Text = cus.Dienthoai.Trim();
            }
        }

        private void btbUpdate_Click(object sender, EventArgs e)
        {
            bool isFill = fInfor.CheckFillInText(new Control[] { txbHT, txbQT, txbDC, txbDT });
            if (!isFill)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txbCMND.Text == cus.Cmnd.Trim() && txbHT.Text == cus.Hoten.Trim() && txbQT.Text == cus.Quoctich.Trim() && txbDC.Text == cus.Diachi.Trim() && txbDT.Text == cus.Dienthoai.Trim())
            {
                MessageBox.Show("Bạn chưa thay đổi dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = CustomerDAO.Instance.UpdateInforCustomer(txbCMND.Text, txbHT.Text, txbQT.Text, txbDC.Text, txbDT.Text);

            if (count > 0)
            {
                MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi câp nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btbDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + txbHT.Text.ToString() + " hay không ? ", "Xác nhận xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int count = CustomerDAO.Instance.DeleteCustomer(txbCMND.Text.ToString());
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
