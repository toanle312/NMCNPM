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
    public partial class fMaStaff : Form
    {
        List<StaffDTO> listStaff = new List<StaffDTO>();
        public fMaStaff()
        {
            InitializeComponent();
            LoadStaff();
        }

        public void LoadStaff()
        {
            lsvNV.Items.Clear();
            listStaff = MaStaffDAO.Instance.LoadFullStaff();

            foreach (StaffDTO item in listStaff)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaNV.ToString());
                lsvItem.SubItems.Add(item.HoTen.ToString());
                lsvItem.SubItems.Add(item.CCCD.ToString());
                lsvItem.SubItems.Add(item.GioiTinh.ToString());
                lsvItem.SubItems.Add(item.DiaChi.ToString());
                lsvItem.SubItems.Add(item.DienThoai.ToString());
                lsvItem.SubItems.Add(item.MaTK.ToString());

                lsvNV.Items.Add(lsvItem);
            }
        }

        private void ptbAdd_Click(object sender, EventArgs e)
        {
            fAddStaff f  = new fAddStaff();
            f.ShowDialog();

            LoadStaff();
        }

        private void lbAdd_Click(object sender, EventArgs e)
        {
            fAddStaff f = new fAddStaff();
            f.ShowDialog();

            LoadStaff();
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            string searchMaNV = txbSearch.Text.Trim();            
            if (txbSearch.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = 0;
            foreach (StaffDTO item in listStaff)
            {
                if (searchMaNV == item.MaNV.ToString().Trim())
                {
                    count++;
                }
            }
            
            if (count > 0)
            {
                fIStaff f = new fIStaff(searchMaNV);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadStaff();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
