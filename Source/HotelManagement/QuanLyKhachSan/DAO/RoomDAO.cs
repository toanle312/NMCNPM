using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public  class RoomDAO
    {
        private static RoomDAO _instance;
        public static RoomDAO Instance {
            get { if (_instance == null) _instance = new RoomDAO(); return _instance; }
            private set => _instance = value;
        }
        public static int RoomWidth = 160;
        public static int RoomHeight = 160;
        private RoomDAO() { }
        public List<RoomDTO> LoadRoomList()
        {
            List<RoomDTO> listRoom = new List<RoomDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from PHONG");

            foreach(DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item); 
                listRoom.Add(room);
            }
            return listRoom;
        }
        public bool addRoom (string MaPhong, string TinhTrang, string LoaiPhong)
        {
            string query = "USP_AddRoom @MaPhong , @TinhTrang , @LoaiPhong ";
            int res = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaPhong, TinhTrang, LoaiPhong });
            return res > 0;
        }
        public bool updateRoom(string MaPhong, string TinhTrang, string LoaiPhong)
        {
            string query = "USP_UpdateRoom @MaPhong , @TinhTrang , @LoaiPhong";
            int res = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { MaPhong, TinhTrang, LoaiPhong });
            return res > 0;
        }
    }
}
