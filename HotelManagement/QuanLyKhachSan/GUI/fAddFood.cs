﻿using DAO;
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
    public partial class fAddFood : Form
    {
        public fAddFood()
        {
            InitializeComponent();
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            string MaPhong = txtMaPhong.Text;
            string TinhTrang = txtTinhTrang.Text;
            string LoaiPhong = txtLoaiPhong.Text;

            if (RoomDAO.Instance.addRoom(MaPhong, TinhTrang, LoaiPhong))
            {
                MessageBox.Show("Thêm phòng mới thành công");
                RoomDAO.Instance.LoadRoomList();
            }
            else
            {
                MessageBox.Show("Thêm phòng mới xảy ra lỗi vui lòng kiểm tra lại");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
