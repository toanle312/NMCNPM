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
    public partial class fUpdateRoom : Form
    {
        public fUpdateRoom()
        {
            InitializeComponent();
        }

        private void btn_CapNhatPhong_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhong.Text;
            string TinhTrang = txtTinhTrang.Text;
            string LoaiPhong = txtLoaiPhong.Text;

            if (RoomDAO.Instance.updateRoom(MaPhong, TinhTrang, LoaiPhong))
            {
                MessageBox.Show("Cập nhật phòng thành công");
                RoomDAO.Instance.LoadRoomList();
            }
            else
            {
                MessageBox.Show("Cập nhật phòng xảy ra lỗi vui lòng kiểm tra lại");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
