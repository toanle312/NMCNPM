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

namespace GUI
{
    public partial class fAddCustomer : Form
    {
        public fAddCustomer()
        {
            InitializeComponent();
        }

        private void ptxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btbAdd_Click(object sender, EventArgs e)
        {
            bool isFill = fInfor.CheckFillInText(new Control[] { textCMND, textHoTen, textQT, textDC, textDT });
            if (!isFill)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int count = CustomerDAO.Instance.InsertCustomer(textCMND.Text.ToString(), textHoTen.Text.ToString(), textQT.Text.ToString(), textDC.Text.ToString(), textDT.Text.ToString());
                if (count > 0)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Khách Hàng đã tồn tại\nTrùng số chứng minh nhân dân", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi thêm khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


    }
}
