using DVLD_BusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Forms
{
    public partial class frmManagePeople : Form
    {
        private DataTable _dt;
        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _dt = clsPeople.GetAllPeople();
            dgvPeople.DataSource = _dt;
            lblRecCount.Text = _dt.Rows.Count.ToString();
          
            cbFilterBy.SelectedIndex = 0;
            tbFilterBy.Visible = false;
            rbMale.Visible = rbFeMale.Visible = false;
        }

        private void tbFilterBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColumn = cbFilterBy.SelectedItem?.ToString() ?? "None";

            if (selectedColumn == "None")
            {
                tbFilterBy.Visible = false;
                rbMale.Visible = rbFeMale.Visible = false;
                _dt.DefaultView.RowFilter = "";
                return;
            }

            if (selectedColumn == "Gendor")
            {
                tbFilterBy.Visible = false;
                rbMale.Visible = rbFeMale.Visible = true;
            }
            else
            {
                tbFilterBy.Visible = true;
                rbMale.Visible = rbFeMale.Visible = false;
            }

            ApplyFilter();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                ApplyFilter();
        }

        private void rbFeMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFeMale.Checked)
                ApplyFilter();
        }

        private void ApplyFilter()
        {
            string selectedColumn = cbFilterBy.SelectedItem?.ToString();
            string filter = string.Empty;

            if (string.IsNullOrEmpty(selectedColumn) || selectedColumn == "None")
            {
                _dt.DefaultView.RowFilter = "";
            }
            else if (selectedColumn == "Gendor")
            {
                if (rbMale.Checked)
                    filter = "Gendor = 'Male'";
                else if (rbFeMale.Checked)
                    filter = "Gendor = 'Female'";
            }
            else if (!string.IsNullOrWhiteSpace(tbFilterBy.Text))
            {
                filter = $"{selectedColumn} LIKE '%{tbFilterBy.Text.Replace("'", "''")}%'";
            }

            _dt.DefaultView.RowFilter = filter;
            lblRecCount.Text = dgvPeople.Rows.Count.ToString();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Show Details");
        }

        private void tsmiAddNewPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Person");
        }

        private void tsmiEditPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Edit Person");
        }

        private void tsmiDeletePerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Delete Person");
        }

        private void tsmiSendEmailToPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email To Person");
        }

        private void tsmiPhoneCallPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call Person");
        }
    }
}
