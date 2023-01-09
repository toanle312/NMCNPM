using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO _instance;

        public static QuyDinhDAO Instance
        {
            get { if (_instance == null) _instance = new QuyDinhDAO(); return _instance; }
            private set => _instance = value;
        }

        private QuyDinhDAO() { }

        public List<QuyDinhDTO> LoadInformation()
        {
            List<QuyDinhDTO> list = new List<QuyDinhDTO>();
            string query = "GetRoomType ";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                QuyDinhDTO l = new QuyDinhDTO(item);
                list.Add(l);
            }

            return list;
        }
    }
}
