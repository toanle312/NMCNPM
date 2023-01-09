using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fService : Form
    {
        BindingSource serviceList = new BindingSource();
        public fService()
        {
            InitializeComponent();
            LoadServices();
            AddServiceBinding();
        }

        void LoadServices()
        {
            serviceView.DataSource = serviceList;

            serviceList.DataSource = ServiceDAO.Instance.LoadServiceListDAO();
            //AddServiceBinding();
        }

        void AddServiceBinding()
        {
            nameService.DataBindings.Add(new Binding("Text", serviceView.DataSource, "TenDV",true,DataSourceUpdateMode.Never));
            noteService.DataBindings.Add(new Binding("Text", serviceView.DataSource, "GhiChu", true, DataSourceUpdateMode.Never));
            priceService.DataBindings.Add(new Binding("Text", serviceView.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serviceView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameService.Text;
            string note = noteService.Text;
            SqlMoney price = SqlMoney.Parse(priceService.Text);

            if(ServiceDAO.Instance.InsertFood(name,price, note))
            {
                MessageBox.Show("Thêm mới dịch vụ thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServices();
            }
            else
            {
                MessageBox.Show("Thêm mới dịch vụ thất bại","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadServices();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = nameService.Text;
            string note = noteService.Text;
            SqlMoney price = SqlMoney.Parse(priceService.Text);

            if (ServiceDAO.Instance.UpdateFood(name, price, note))
            {
                MessageBox.Show("Cập nhật dịch vụ thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServices();
            }
            else
            {
                MessageBox.Show("Cập nhật dịch vụ thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadServices();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            string name = nameService.Text;

            if (ServiceDAO.Instance.DeleteService(name))
            {
                MessageBox.Show("Xóa dịch vụ thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServices();
            }
            else
            {
                MessageBox.Show("Xóa dịch vụ thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadServices();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
