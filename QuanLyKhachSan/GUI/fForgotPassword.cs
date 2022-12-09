using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fForgotPassword : Form
    {
    
        public fForgotPassword()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string query = "Select EmailXacNhan from TAIKHOAN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<String> emails = new List<string>();

            foreach (DataRow row in data.Rows)
            {
                emails.Add(row["EmailXacNhan"].ToString().Trim());
            }    
            if(emailTextBox.Text == "")
            {
                label1.Text = "Email không được để trống";
                label1.ForeColor = Color.Red;
            }    
            else if(emails.Contains(emailTextBox.Text))
            {
                this.Hide();
                fSucceedEmail succeedEmail = new fSucceedEmail(emailTextBox.Text);
                succeedEmail.ShowDialog();
            }
            else
            {
                label1.Text = "Email không tồn tại hoặc không đúng định dạng";
                label1.ForeColor = Color.Red;
            }
        }

        private void exitPTB_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
