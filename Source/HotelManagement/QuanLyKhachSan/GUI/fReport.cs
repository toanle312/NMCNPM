using BUS;
using DAO;
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
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        void LoadReportRevenue(int month, int year)
        {
            reportView.Clear();

            reportView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});

            columnHeader1.Text = "Loại Phòng";
            columnHeader1.Width = 210;
            columnHeader2.Text = "Doanh Thu";
            columnHeader2.Width = 210;
            columnHeader3.Text = "Tỉ Lệ";
            columnHeader3.Width = 210;

            reportView.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            var report = ReportRevenueBUS.LoadReportRevenue(month, year);

            foreach(var item in report)
            {
                ListViewItem lsvItem = new ListViewItem(item.LoaiPhong);
                lsvItem.SubItems.Add(item.DoanhThu);
                lsvItem.SubItems.Add(item.TiLe);

                lsvItem.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                reportView.Items.Add(lsvItem);
            }
        }

        void LoadReportDensity(int month, int year)
        {
            reportView.Clear();

            reportView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});

            columnHeader1.Text = "Phòng";
            columnHeader1.Width = 210;
            columnHeader2.Text = "Số Ngày Thuê";
            columnHeader2.Width = 210;
            columnHeader3.Text = "Tỉ Lệ";
            columnHeader3.Width = 210;

            reportView.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

            var report = ReportDensityBUS.LoadReportDensity(month, year);
            foreach (var item in report)
            {
                ListViewItem lsvItem = new ListViewItem(item.Phong);
                lsvItem.SubItems.Add(item.SoNgayThue);
                lsvItem.SubItems.Add(item.TiLe);

                lsvItem.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

                reportView.Items.Add(lsvItem);
            }
        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            bool checkFill = fInfor.CheckFillInText(new Control[] { monthComboBox, yearComboBox, typeOfReport });

            if(checkFill == true)
            {
                int month = Int32.Parse(monthComboBox.Text);
                int year = Int32.Parse(yearComboBox.Text);
                int type = typeOfReport.SelectedIndex;

                monthReport.Text = month.ToString();
                yearReport.Text = year.ToString();

                if (type == 0)
                {
                    typeReport.Text = "BÁO CÁO DOANH THU THEO LOẠI PHÒNG";
                    LoadReportRevenue(month, year);
                }
                else
                {
                    typeReport.Text = "BÁO CÁO MẬT ĐỘ SỬ DỤNG PHÒNG";
                    LoadReportDensity(month, year);
                }
            }
            else
            {
                MessageBox.Show("Các ô không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void typeReport_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
