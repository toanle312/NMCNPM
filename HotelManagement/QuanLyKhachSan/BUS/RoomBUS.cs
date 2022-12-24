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
            List<RoomDTO> roomList = RoomDAO.Instance.LoadRoomList();

            return roomList;
        }
    }
}
