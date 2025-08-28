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
        DataTable dt;
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            dt =  clsPeople.GetAllPeople();
            dgvPeople.DataSource = dt;  
            lblRecCount.Text = dt.Rows.Count.ToString();
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            if(tbFilterBy.Text != "")
            {
                dt.DefaultView.RowFilter = $"{GetFilterBy()} = '{tbFilterBy.Text.ToString()}'";
            }
            else
            {
                dt.DefaultView.RowFilter = "";
            }
        }

        private string GetFilterBy()
        {
            return cbFilterBy.SelectedItem.ToString();
        }
    }
}
