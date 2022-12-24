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
    public partial class fLapPhieuThuePhong : Form
    {
        private string _cmnd;
        private string _maphong;
        private string _songuoi;
        private string _ngoaiquoc;
        private string _maphieu;
        private string _mahd;
        private List<PhieuThuePhong> list;
        public fLapPhieuThuePhong()
        {
            int i = 0;
            InitializeComponent();
            list = HoaDonDAO.Instance.ds_phieuthuephong();
            foreach (PhieuThuePhong phieuThuePhong in list)
            {
                i++;
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(phieuThuePhong.Maphieu);
                item.SubItems.Add(phieuThuePhong.Cmnd);
                item.SubItems.Add(phieuThuePhong.Songuoi);
                item.SubItems.Add(phieuThuePhong.Ngoaiquoc);
                listView1.Items.Add(item);
            }
            
        }

        public string Cmnd { get => _cmnd; set => _cmnd = value; }
        public string Songuoi { get => _songuoi; set => _songuoi = value; }
        public string Ngoaiquoc { get => _ngoaiquoc; set => _ngoaiquoc = value; }
        public string Maphieu { get => _maphieu; set => _maphieu = value; }
        public string Maphong { get => _maphong; set => _maphong = value; }
        public string Mahd { get => _mahd; set => _mahd = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            Cmnd = cmnd.Text.ToString();
            Maphong = maphong.Text.ToString();
            Songuoi = songuoi.Text.ToString();
            Ngoaiquoc = ngoaiquoc.Text.ToString();
            if (Cmnd.Equals("") || Maphong.Equals("")|| Songuoi.Equals("")|| Ngoaiquoc.Equals(""))
            {
                MessageBox.Show("Không được để dữ liệu trống");
                return;
            }
            DataRow dt = HoaDonDAO.Instance.lap_phieuthuephong(Cmnd, Songuoi, "NV001", Ngoaiquoc);
            Maphieu = dt["MaPhieu"].ToString();
            DataRow dt1 = HoaDonDAO.Instance.tao_hoadon(Cmnd, "NV001");
            Mahd = dt1["MaHD"].ToString();
            HoaDonDAO.Instance.themchitietphong(Maphong, Mahd, Maphieu);
        }

        private void fLapHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitPTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
