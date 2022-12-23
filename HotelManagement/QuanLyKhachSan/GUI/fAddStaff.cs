using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class fAddStaff : Form
    {
        public fAddStaff()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            bool isFill = fInfor.CheckFillInText(new Control[] { txbMaNV , txbHT, txbCMND, txbGT ,txbDC, txbDT, txbMaTK });
            if (!isFill)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int count = MaStaffDAO.Instance.InsertStaff(txbMaNV.Text.ToString(), txbHT.Text.ToString(), txbCMND.Text.ToString(), txbGT.Text.ToString(), txbDC.Text.ToString(), txbDT.Text.ToString(), txbMaTK.Text.ToString());
                if (count > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Nhân viên đã tồn tại\nTrùng số chứng minh nhân dân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
