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
    }
}
