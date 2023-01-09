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
    public partial class fCustomer : Form
    {
        List<CustomerDTO> listCustomer = new List<CustomerDTO>();
        public fCustomer()
        {
            InitializeComponent();
            LoadCustomer();
        }

        public void LoadCustomer()
        {
            lsvCustomer.Items.Clear();
            listCustomer = CustomerDAO.Instance.LoadInformation();
           
            foreach (CustomerDTO item in listCustomer) 
            {
                ListViewItem lsvItem = new ListViewItem(item.Cmnd.ToString());
                lsvItem.SubItems.Add(item.Hoten.ToString());
                lsvItem.SubItems.Add(item.Quoctich.ToString());
                lsvItem.SubItems.Add(item.Diachi.ToString());
                lsvItem.SubItems.Add(item.Dienthoai.ToString());

                lsvCustomer.Items.Add(lsvItem);
            }
        }

        private void lAdd_Click(object sender, EventArgs e)
        {
            fAddCustomer f = new fAddCustomer();
            f.ShowDialog();

            LoadCustomer();
        }

        private void ptb_Add_Click(object sender, EventArgs e)
        {
            fAddCustomer f = new fAddCustomer();
            f.ShowDialog();
            
            LoadCustomer();
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            string searchCMND = txbSearch.Text.Trim();     
            
            if (txbSearch.Text == string.Empty)
            {
                MessageBox.Show("Không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = 0;
            foreach (CustomerDTO item in listCustomer)
            {
                if (searchCMND == item.Cmnd.ToString().Trim())
                {
                    count++;
                }
            }

            if (count > 0)
            {
                fCustomerInfor f = new fCustomerInfor(searchCMND);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadCustomer();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
