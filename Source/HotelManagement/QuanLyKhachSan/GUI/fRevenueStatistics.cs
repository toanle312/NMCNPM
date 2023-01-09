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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class fRevenueStatistics : Form
    {
        public fRevenueStatistics()
        {
            InitializeComponent();
        }

        void loadStatisticsRevenue(int month, int year)
        {
            DataTable dt = new DataTable();
            listView.View = View.Details;
            listView.FullRowSelect = true;

            listView.Columns.Add("Loại phòng", 250);
            listView.Columns.Add("Doanh thu", 250);
            listView.Columns.Add("Tỷ lệ", 250);

            dt = StatisticsRevenueDAO.Instance.MakeStatisticsRevenueDAO(month, year);

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                listView.Items.Add(item);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_XemThongKe_Click(object sender, EventArgs e)
        {
            int month = Int32.Parse(txtThang.Text);
            month.ToString();

            int year = Int32.Parse(txtNam.Text);
            year.ToString();

            loadStatisticsRevenue(month, year);
        }
    }
}
