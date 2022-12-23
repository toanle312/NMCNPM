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
    public partial class fQuyDinh : Form
    {
        List<QuyDinhDTO> listQD= new List<QuyDinhDTO>();
        public fQuyDinh()
        {
            InitializeComponent();
            LoadInfo();
        }

        public void LoadInfo()
        {
            lsvQD.Items.Clear();
            listQD = QuyDinhDAO.Instance.LoadInformation();

            foreach (QuyDinhDTO item in listQD)
            {
                ListViewItem lsvItem = new ListViewItem(item.LoaiPhong.ToString());
                lsvItem.SubItems.Add(item.Dongia.ToString());
                lsvItem.SubItems.Add(item.Mota.ToString());
                

                lsvQD.Items.Add(lsvItem);
            }
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
