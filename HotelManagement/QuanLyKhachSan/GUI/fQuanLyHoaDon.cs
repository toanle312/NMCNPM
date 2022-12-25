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
    public partial class fQuanLyHoaDon : Form
    {
        private List<HoaDon> hoadons;
        private List<HoaDon> hoadons1;
        public int curpos;
        public fQuanLyHoaDon()
        {
            hoadons = HoaDonDAO.Instance.get_list_HoaDon();
            hoadons1 = HoaDonDAO.Instance.get_list_HoaDon_chuathanhtoan();
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hoadons;
            dataGridView2.DataSource = hoadons1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double total_money = 0;
            listView1.Items.Clear();
            curpos = dataGridView1.CurrentCell.RowIndex;
            int i = 0;
            textBox1.Text = hoadons[curpos].Mahd;
            textBox2.Text = hoadons[curpos].Ten;
            textBox3.Text = hoadons[curpos].CMND;
            textBox4.Text = hoadons[curpos].Ngay;
            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            List<ChiTietDichVu> chiTietDichVus = new List<ChiTietDichVu>();
            chiTietHoaDons = HoaDonDAO.Instance.get_list_ChiTietHoaDonPhong(hoadons[curpos].Mahd);
            chiTietDichVus = HoaDonDAO.Instance.get_list_ChiTietHoaDonDichVu(hoadons[curpos].Mahd);
            foreach(ChiTietHoaDon chiTietHoaDon in chiTietHoaDons)
            {
                i++;
                ListViewItem list = new ListViewItem(i.ToString());
                list.SubItems.Add(chiTietHoaDon.Phong);
                list.SubItems.Add(chiTietHoaDon.Songay);
                double dongia1=double.Parse(chiTietHoaDon.Dongia);
                list.SubItems.Add(dongia1.ToString());
                double phuthu = 0;
                double tongtien = double.Parse(chiTietHoaDon.Songay) * double.Parse(chiTietHoaDon.Dongia);
                if (chiTietHoaDon.Ngoaiquoc.Equals("Không"))
                {
                    if (chiTietHoaDon.Songuoi <= 2) phuthu = 0;
                    else phuthu = tongtien * 0.25;
                }
                else
                {
                    if (chiTietHoaDon.Songuoi <= 2) phuthu = tongtien*0.5;
                    else phuthu = tongtien * 0.875;
                }
                tongtien = tongtien + phuthu;
                total_money += tongtien;
                list.SubItems.Add(phuthu.ToString());
                list.SubItems.Add(tongtien.ToString());
                listView1.Items.Add(list);

            }
            foreach(ChiTietDichVu chiTietDichVu in chiTietDichVus)
            {
                i++;
                ListViewItem list = new ListViewItem(i.ToString());
                list.SubItems.Add(chiTietDichVu.Tenmon);
                list.SubItems.Add(chiTietDichVu.Soluong);
                double dongia = double.Parse(chiTietDichVu.Thanhtien) /double.Parse( chiTietDichVu.Soluong);
                list.SubItems.Add(dongia.ToString());
                list.SubItems.Add("0");
                double Thanhtien1 = double.Parse(chiTietDichVu.Thanhtien);
                list.SubItems.Add(Thanhtien1.ToString());
                total_money += double.Parse(chiTietDichVu.Thanhtien);
                listView1.Items.Add(list);
            }
            label5.Text = "Tổng tiền: " + total_money.ToString();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Chọn hoá đơn cần xoá");

                return;
            }
            HoaDonDAO.Instance.delete_HoaDon(hoadons[curpos].Mahd);
            curpos = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.DataSource = null;
            hoadons.Remove(hoadons[curpos]);
            dataGridView1.DataSource = hoadons;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            listView1.Items.Clear();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double total_money = 0;
            //listView2.Items.Clear();
            curpos = dataGridView1.CurrentCell.RowIndex;
            HoaDonDAO.Instance.capnhatthanhtien(hoadons1[curpos].Mahd);
            HoaDonDAO.Instance.capnhathoadon(hoadons1[curpos].Mahd);
            int i = 0;
            textBox8.Text = hoadons1[curpos].Mahd;
            textBox7.Text = hoadons1[curpos].Ten;
            textBox6.Text = hoadons1[curpos].CMND;
            textBox5.Text = hoadons1[curpos].Ngay;
            List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            List<ChiTietDichVu> chiTietDichVus = new List<ChiTietDichVu>();
            chiTietHoaDons = HoaDonDAO.Instance.get_list_ChiTietHoaDonPhong(hoadons1[curpos].Mahd);
            chiTietDichVus = HoaDonDAO.Instance.get_list_ChiTietHoaDonDichVu(hoadons1[curpos].Mahd);
            foreach (ChiTietHoaDon chiTietHoaDon in chiTietHoaDons)
            {
                i++;
                ListViewItem list = new ListViewItem(i.ToString());
                list.SubItems.Add(chiTietHoaDon.Phong);
                list.SubItems.Add(chiTietHoaDon.Songay);
                double dongia1 = double.Parse(chiTietHoaDon.Dongia);
                list.SubItems.Add(dongia1.ToString());
                double phuthu = 0;
                double tongtien = double.Parse(chiTietHoaDon.Songay) * double.Parse(chiTietHoaDon.Dongia);
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
                total_money += tongtien;
                list.SubItems.Add(phuthu.ToString());
                list.SubItems.Add(tongtien.ToString());
                listView2.Items.Add(list);

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
                double Thanhtien1 = double.Parse(chiTietDichVu.Thanhtien);
                list.SubItems.Add(Thanhtien1.ToString());
                total_money += double.Parse(chiTietDichVu.Thanhtien);
                listView2.Items.Add(list);
            }
            label10.Text = "Tổng tiền: " + total_money.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Equals(""))
            {
                MessageBox.Show("Chọn hoá đơn cần thanh toán");
                return;
            }
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            listView2.Items.Clear();
            this.Hide();
            fInHoaDon fInHoaDon = new fInHoaDon(hoadons1[curpos].CMND);
            fInHoaDon.ShowDialog();
            this.Show();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void exitPTB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
