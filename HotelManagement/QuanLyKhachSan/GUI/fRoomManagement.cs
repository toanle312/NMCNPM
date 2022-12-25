using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.Click += Btn_Click;
                btn.Tag = room;

                switch (room.TinhTrang)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(102, 255, 102);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(153, 255, 153);
                        var image1 = (Bitmap)Properties.Resources.ResourceManager.GetObject("_checked");
                        btn.Image = image1;
                        btn.ImageAlign = ContentAlignment.BottomLeft;
                        break;
                    case "Đang sử dụng":
                        btn.BackColor = Color.FromArgb(255, 255, 102);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 153);
                        var image2 = (Bitmap)Properties.Resources.ResourceManager.GetObject("double_bed");
                        btn.Image = image2;
                        btn.ImageAlign = ContentAlignment.BottomLeft;
                        break;
                    case "Bảo trì":
                        btn.BackColor = Color.FromArgb(255, 102, 102);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 153);
                        var image3 = (Bitmap)Properties.Resources.ResourceManager.GetObject("tools");
                        btn.Image = image3;
                        btn.ImageAlign = ContentAlignment.BottomLeft;
                        break;
                }

                flpLeft.Controls.Add(btn);
            }

            

        }

        #endregion

        #region Events
        #endregion

        private void Btn_Click(object? sender, EventArgs e)
        {
            RoomDTO? room = (sender as Button).Tag as RoomDTO;
            id.Text = room.MaPhong.Trim();
            type.Text = room.LoaiPhong.Trim();

            switch (room.LoaiPhong.Trim())
            {
                case "A":
                    price.Text = "150000";
                    break;
                case "B":
                    price.Text = "170000";
                    break;
                case "C":
                    price.Text = "200000";
                    break;
            }

            status.Text = room.TinhTrang.Trim();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            fAddRoom fa = new fAddRoom();
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

        private void flpLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
