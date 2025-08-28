using DVLD_BusinessLayer;
using System;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Forms
{
    public partial class frmLogin : Form
    {
        private string _userName;
        private string _password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginData();
            Global.User = clsUser.Find(_userName, _password);

            if (Global.User != null) 
            {
                SaveLoginInfo();
                this.Hide();
                Form main = new frmMain();
                main.ShowDialog();
                this.Show();

            }
            else
            {
                MessageBox.Show("Invald Login");
            }
        }

        private void LoginData()
        {
            _userName = tbUserName.Text;
            _password = tbPassword.Text;
        }
        private void SaveLoginInfo() 
        { 
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.RememberMe = true;
                Properties.Settings.Default.UserName = tbUserName.Text;
                Properties.Settings.Default.Password =tbPassword.Text; 
            }
            else
            {
                Properties.Settings.Default.RememberMe = false;
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
            }

            Properties.Settings.Default.Save();
        }
        private void GetLoginInfo()
        {
            if (Properties.Settings.Default.RememberMe)
            {
                chkRememberMe.Checked = true;
                tbUserName.Text = Properties.Settings.Default.UserName;
                tbPassword.Text = Properties.Settings.Default.Password;
            }

        }
        
        private void frmLogin_Load(object sender, EventArgs e)
        {
            GetLoginInfo();
        }
    }
}
