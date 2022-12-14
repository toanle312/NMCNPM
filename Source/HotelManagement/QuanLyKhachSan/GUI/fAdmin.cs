using BUS;
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
    public partial class fAdmin : Form
    {
        AccountDTO set_account = new AccountDTO(); 
        public fAdmin(AccountDTO account)
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
            ManagerDTO manager = ManagerBUS.LoadInformation(set_account);
            nameLabel.Text = manager.HoTen;
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
            fInforAdmin infor = new fInforAdmin(set_account);
            var result = infor.ShowDialog();
            if(result == DialogResult.OK)
            {
                ManagerDTO manager = ManagerBUS.LoadInformation(set_account);
                nameLabel.Text = manager.HoTen;
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

        }

        private void makeBillBtn_Click(object sender, EventArgs e)
        {

        }

        private void makeReportBtn_Click(object sender, EventArgs e)
        {

        }

        private void manageClientBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fCustomer cus = new fCustomer();
            cus.ShowDialog();
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

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void mangeStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMaStaff maStaff = new fMaStaff();
            maStaff.ShowDialog();
            this.Show();
        }

        private void thongKeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fStatistics thongke = new fStatistics();
            thongke.ShowDialog();
            this.Show();
        }

        private void changeRegulationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            fQuyDinh quydinh = new fQuyDinh();
            quydinh.ShowDialog();
            this.Show();
        }
    }
}
