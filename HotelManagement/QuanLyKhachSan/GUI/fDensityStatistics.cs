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
    public partial class fDensityStatistics : Form
    {
        public fDensityStatistics()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void loadStatisticsDensity(int month, int year)
        {
            DataTable dt = new DataTable();
            listView.View = View.Details;
            listView.FullRowSelect = true;

            listView.Columns.Add("Phòng", 250);
            listView.Columns.Add("Số ngày thuê", 250);
            listView.Columns.Add("Tỷ lệ", 250);

            dt = StatisticsDensityDAO.Instance.MakeStatisticsDensityDAO(month, year);

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

        private void btn_XemThongKe_Click_1(object sender, EventArgs e)
        {
            int month = Int32.Parse(txtThang.Text);
            month.ToString();

            int year = Int32.Parse(txtNam.Text);
            year.ToString();

            loadStatisticsDensity(month, year);
        }
    }
}
