using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoomBUS
    {
        public static List<RoomDTO> LoadRoomList()
        {
            DataTable data = RoomDAO.Instance.LoadRoomListDAO();

            List<RoomDTO> roomList = new List<RoomDTO>();

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                roomList.Add(room);
            }

            return roomList;
        }
    }
}
