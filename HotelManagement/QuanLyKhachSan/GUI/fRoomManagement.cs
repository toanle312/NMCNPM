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
    public partial class fRoomManagement : Form
    {
        public fRoomManagement()
        {
            InitializeComponent();
            LoadRoom();
        }

        #region Method
        void LoadRoom()
        {
            List<RoomDTO> roomList =  RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO room in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                btn.Text = room.MaPhong + Environment.NewLine + room.TinhTrang + Environment.NewLine + room.LoaiPhong;
                switch (room.TinhTrang)
                {
                    case "Đang sử dụng":
                        btn.BackColor = Color.OrangeRed;
                        break;
                    case "Trống":
                        btn.BackColor = Color.FromArgb(100, 232, 88);
                        break;
                    case "Bảo trì":
                        btn.BackColor = Color.SkyBlue;
                        break;

                }
                flpLeft.Controls.Add(btn);
            }

        }

        #endregion

        #region Events
        #endregion

        private void btn_Them_Click(object sender, EventArgs e)
        {
            fAddFood fa = new fAddFood();
            fa.Show();

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            fUpdateRoom fu = new fUpdateRoom();
            fu.Show();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
