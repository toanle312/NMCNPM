using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fSearchRoom : Form
    {
        List<RoomDTO> roomList = RoomBUS.LoadRoomList();

        public fSearchRoom()
        {
            InitializeComponent();
            LoadRoom(roomList);
        }


        void LoadRoom(List<RoomDTO> roomList)
        {
            price.Text = "";
            status.Text = "";
            id.Text = "";
            type.Text = "";

            showRoom.Controls.Clear();
            foreach (RoomDTO room in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };
                
                btn.Text = room.MaPhong + Environment.NewLine + room.TinhTrang;
                btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.Click += Btn_Click;
                btn.Tag = room;

                switch(room.TinhTrang)
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
                        btn.BackColor = Color.FromArgb(255,102,102);
                        btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 153);
                        var image3 = (Bitmap)Properties.Resources.ResourceManager.GetObject("tools");
                        btn.Image = image3;
                        btn.ImageAlign = ContentAlignment.BottomLeft;
                        break;
                }    

                showRoom.Controls.Add(btn);
            }
        }

        void ShowInfoRoom(RoomDTO room)
        {

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            RoomDTO? room = (sender as Button).Tag as RoomDTO;
            id.Text = room.MaPhong.Trim();
            type.Text = room.LoaiPhong.Trim();
            
            switch(room.LoaiPhong.Trim())
            {
                case "A":
                    price.Text ="150000";
                    break;
                case "B":
                    price.Text ="170000";
                    break;
                case "C":
                    price.Text = "200000";
                    break;
            }

            status.Text = room.TinhTrang.Trim();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string idRoom = idTextBox.Text;
            if(idRoom == null)
            {
                return;
            }

            var filterRoom = new List<RoomDTO>();

            foreach (RoomDTO room in roomList)
            {
                if (room.MaPhong.Contains(idRoom.Trim().ToUpper()))
                {
                    filterRoom.Add(room);
                }      
            }

            LoadRoom(filterRoom);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        public static List<CheckBox> isChecked(CheckBox[] checkBoxes)
        {
            List<CheckBox> list = new List<CheckBox>();
            foreach (var check in checkBoxes)
            {
                if (check.Checked == true)
                    list.Add(check);
            }

            return list;
        }

        private void typeRoomA_CheckedChanged(object sender, EventArgs e)
        {
            var list1 = isChecked(new CheckBox[] { typeRoomA, typeRoomB, typeRoomC });
            var list2 = isChecked(new CheckBox[] { statusRoom1, statusRoom2, statusRoom3 });

            if(list1.Count == 0 && list2.Count == 0)
            {
                LoadRoom(roomList);
                return;
            }

            var filterRoom = new List<RoomDTO>();

            if (list1.Count != 0 && list2.Count == 0)
            {
                var checkType = list1[0];
                
                if (list1.Count == 1)
                {
                  
                    foreach (var item in roomList)
                    {
                        if (item.LoaiPhong.Trim() == checkType.Text)
                        {
                            filterRoom.Add(item);
                        }
                    }
                }
                else
                {
                    showRoom.Controls.Clear();
                    return;
                }
            }
            else if(list1.Count == 0 && list2.Count != 0)
            {
                var checkStatus = list2[0];
                if (list2.Count == 1)
                {
                   
                    foreach (var item in roomList)
                    {
                        if (item.TinhTrang.Trim() == checkStatus.Text)
                        {
                            filterRoom.Add(item);
                        }
                    }
                }
                else
                {
                    showRoom.Controls.Clear();
                    return;
                }
            }
            else if (list1.Count != 0 && list2.Count != 0)
            {
                var checkType = list1[0];
                var checkStatus = list2[0];
                if (list1.Count == 1 && list2.Count == 1)
                {
                    
                    foreach (var item in roomList)
                    {
                        if (item.LoaiPhong.Trim() == checkType.Text && item.TinhTrang.Trim() == checkStatus.Text)
                        {
                            filterRoom.Add(item);
                        }
                    }
                }
                else
                {
                    showRoom.Controls.Clear();
                    return;
                }
            }
            LoadRoom(filterRoom);
        }

        private void typeRoomB_CheckedChanged(object sender, EventArgs e)
        {
            typeRoomA_CheckedChanged(sender, e);
        }

        private void typeRoomC_CheckedChanged(object sender, EventArgs e)
        {
            typeRoomA_CheckedChanged(sender, e);
        }

        private void statusRoom1_CheckedChanged(object sender, EventArgs e)
        {
            typeRoomA_CheckedChanged(sender, e);
        }

        private void statusRoom2_CheckedChanged(object sender, EventArgs e)
        {
            typeRoomA_CheckedChanged(sender, e);
        }

        private void statusRoom3_CheckedChanged(object sender, EventArgs e)
        {
            typeRoomA_CheckedChanged(sender, e);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
