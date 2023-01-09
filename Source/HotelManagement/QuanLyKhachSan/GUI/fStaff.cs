using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fStaff : Form
    {
        AccountDTO set_account = new AccountDTO(); 
        public fStaff(AccountDTO account)
        {
            InitializeComponent();
            set_account = AccountBUS.GetAccountFromID(account.MaTK);
            menuPanel.Hide();
        }

        private void exitPTB_Click(object sender, EventArgs e)
        {
            fExit exit = new fExit();
            var result = exit.ShowDialog();

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // do nothing
            }
        }

        private void hideMenuPTB_Click(object sender, EventArgs e)
        {
            menuPanel.Hide();
        }

        private void showMenuPTB_Click(object sender, EventArgs e)
        {
            menuPanel.Show();
            StaffDTO staff = StaffBUS.LoadInformation(set_account);
            nameLabel.Text = staff.HoTen;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            fNotice notice = new fNotice();
            var result = notice.ShowDialog();
            if(result == DialogResult.Yes)
            {
                this.Close();
                fLogin f = new fLogin();
                f.Show();
            }
            else
            {
                // do nothing
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            fInfor infor = new fInfor(set_account);
            var result = infor.ShowDialog();

            if(result == DialogResult.OK)
            {
                StaffDTO staff = StaffBUS.LoadInformation(set_account);
                nameLabel.Text = staff.HoTen;
            }

            this.Show();
        }

        private void introduceButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            fIntro intro = new fIntro();
            intro.ShowDialog();
            this.Show();
        }

        private void placeRoomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLapPhieuThuePhong place = new fLapPhieuThuePhong();
            place.ShowDialog();
            this.Show();
        }

        private void searchRoomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fSearchRoom searchRoom = new fSearchRoom();
            searchRoom.ShowDialog();
            this.Show();

        }

        private void makeBillBtn_Click(object sender, EventArgs e)
        {
            fLapPhieuThuePhong fLapHoaDon = new fLapPhieuThuePhong();
            this.Hide();
            fLapHoaDon.ShowDialog();
            this.Show();
        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fReport report = new fReport();
            report.ShowDialog();
            this.Show();
        }

        private void manageClientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomer customer = new fCustomer();
            customer.ShowDialog();
            this.Show();
        }

        private void manageServiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fService service = new fService();
            service.ShowDialog();
            this.Show();
        }

        private void manageBillBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQuanLyHoaDon bill = new fQuanLyHoaDon();
            bill.ShowDialog();
            this.Show();
        }

        private void manageRoomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRoomManagement room = new fRoomManagement();
            room.ShowDialog();
            this.Show();
        }
    }
}
