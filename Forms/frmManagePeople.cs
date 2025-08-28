using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Forms
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            DataTable dt = clsPeople.GetAllPeople();
            dgvPeople.DataSource = dt;
            lblRecCount.Text = dt.Columns.Count.ToString();
        }

    }
}
