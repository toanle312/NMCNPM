using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoomDAO
    {
        private static RoomDAO _instance;

        public static RoomDAO Instance {
            get { if (_instance == null) _instance = new RoomDAO(); return _instance; }
            private set => _instance = value;
        }

        public static int RoomWidth = 150;
        public static int RoomHeight = 140;

        private RoomDAO() { }

        public DataTable LoadRoomListDAO()
        {
            return DataProvider.Instance.ExecuteQuery("proc_load_room");
        }
    }
}
