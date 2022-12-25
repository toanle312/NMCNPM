
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fInHoaDon : Form
    {
        private string _mahd;

        public string Mahd { get => _mahd; set => _mahd = value; }

        public fInHoaDon(string mahd)
        {
            Mahd = mahd;
            InitializeComponent();
        }
        public fInHoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataRow r = HoaDonDAO.Instance.thanhtoan_hoadon(Mahd);
            ten.Text = r["HoTen"].ToString();
            ngay.Text = r["Ngay"].ToString();
            dc.Text = r["DiaChi"].ToString();
            hd.Text = r["MaHD"].ToString();
            label7.Text = r["CMND"].ToString();
            HoaDonDAO.Instance.capnhathoadon(hd.Text);

            double t = 0;
            int i = 0;
            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            List<ChiTietDichVu> chiTietDichVus = new List<ChiTietDichVu>();
            chiTietHoaDons = HoaDonDAO.Instance.get_list_ChiTietHoaDonPhong(hd.Text);
            chiTietDichVus = HoaDonDAO.Instance.get_list_ChiTietHoaDonDichVu(hd.Text);
            foreach (ChiTietHoaDon chiTietHoaDon in chiTietHoaDons)
            {
                i++;
                ListViewItem list = new ListViewItem(i.ToString());
                list.SubItems.Add(chiTietHoaDon.Phong);
                double songay1 = double.Parse(chiTietHoaDon.Songay);
                list.SubItems.Add(songay1.ToString());
                list.SubItems.Add(chiTietHoaDon.Dongia);
                double phuthu = 0;
                double tongtien = (double.Parse(chiTietHoaDon.Songay)+1) * double.Parse(chiTietHoaDon.Dongia);
                if (chiTietHoaDon.Ngoaiquoc.Equals("Không"))
                {
                    if (chiTietHoaDon.Songuoi <= 2) phuthu = 0;
                    else phuthu = tongtien * 0.25;
                }
                else
                {
                    if (chiTietHoaDon.Songuoi <= 2) phuthu = tongtien * 0.5;
                    else phuthu = tongtien * 0.875;
                }
                tongtien = tongtien + phuthu;
                list.SubItems.Add(phuthu.ToString());
                list.SubItems.Add(tongtien.ToString());
                listView1.Items.Add(list);
                t += tongtien;

            }
            foreach (ChiTietDichVu chiTietDichVu in chiTietDichVus)
            {
                i++;
                ListViewItem list = new ListViewItem(i.ToString());
                list.SubItems.Add(chiTietDichVu.Tenmon);
                list.SubItems.Add(chiTietDichVu.Soluong);
                double dongia = double.Parse(chiTietDichVu.Thanhtien) / double.Parse(chiTietDichVu.Soluong);
                list.SubItems.Add(dongia.ToString());
                list.SubItems.Add("0");
                list.SubItems.Add(chiTietDichVu.Thanhtien.ToString());
                listView1.Items.Add(list);
                t += double.Parse(chiTietDichVu.Thanhtien);
            }
            txttongtien.Text = t.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            CaptureScreen();
            button1.Show();
            MessageBox.Show("Xuất hoá đơn thành công");
        }

        private void ngay_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width+50, s.Height+50, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X+65,this.Location.Y+68, 0, 0, new Size(1000,617));
            memoryImage.Save(Application.StartupPath + @"\Bill.Png", ImageFormat.Png);
            memoryImage = new Bitmap(Application.StartupPath + @"\Bill.Png");
        }
        private void printDocument1_PrintPage(System.Object sender,
           System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void exitPTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
