using BUS;
using DTO;
using Microsoft.Win32;

namespace GUI
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.ActiveControl = userNameTextBox;
            passWordTextBox.UseSystemPasswordChar = true;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string pass = passWordTextBox.Text;

            string result = AccountBUS.CheckLogin(username, pass);

            if(result == "admin")
            {
                AccountDTO account = AccountBUS.GetAccountFromID(username);
                this.Hide();
                fAdmin f = new fAdmin(account);
                f.ShowDialog();

            }    
            else if(result == "staff")
            {
                AccountDTO account = AccountBUS.GetAccountFromID(username);

                this.Hide();
                fStaff f = new fStaff(account);
                f.ShowDialog();
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng nhập lại !!!");
        }

        private void exitPTB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // do nothing
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            fForgotPassword forgotPassword = new fForgotPassword();
            forgotPassword.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundPTB_Click(object sender, EventArgs e)
        {
            //
        }

        private void textBox3_Load_1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Load(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                passWordTextBox.Focus();
            }    
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void passWordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passWordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender,e);
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(showPass.Checked)
            {
                passWordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passWordTextBox.UseSystemPasswordChar = true;
            }
        }
    }
}