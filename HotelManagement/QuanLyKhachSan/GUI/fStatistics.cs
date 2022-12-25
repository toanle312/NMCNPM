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
    public partial class fStatistics : Form
    {
        public fStatistics()
        {
            InitializeComponent();
        }

        private void fStatistics_Load(object sender, EventArgs e)
        {

        }

        private void btn_ThongKeTheoDoanhThu_Click(object sender, EventArgs e)
        {
            fRevenueStatistics fr = new fRevenueStatistics();
            fr.Show();
        }

        private void btn_ThongKeTheoMatDoSuDung_Click(object sender, EventArgs e)
        {
            fDensityStatistics fd = new fDensityStatistics();
            fd.Show();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
