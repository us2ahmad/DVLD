using DVLD_BusinessLayer;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsmi_LogOut_Click(object sender, System.EventArgs e)
        {
            Global.User = new clsUser(); 
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            Form frm = new frmManagePerson();
            frm.ShowDialog();
            
        }
    }
}
