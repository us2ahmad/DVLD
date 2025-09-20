using DVLD_BusinessLayer;
using DVLD_BusinessLayer.Events;
using DVLD_PresentationLayer.Controls;
using DVLD_PresentationLayer.Forms.People;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Forms
{
    public partial class frmManagePerson : Form
    {
        private DataTable _dt;
        public frmManagePerson()
        {
            InitializeComponent();
        }

        private void frmManagePerson_Load(object sender, EventArgs e)
        {
            LoadPeopleData();

            cbFilterBy.SelectedIndex = 0;
            tbFilterBy.Visible = false;
            rbMale.Visible = rbFeMale.Visible = false;

            PersonEvents.PersonChanged += RefreshPeopleData;
        }

        private void LoadPeopleData()
        {
            _dt = clsPerson.GetAllPerson();
            dgvPerson.DataSource = _dt;
            lblRecCount.Text = _dt.Rows.Count.ToString();
        }

        private void RefreshPeopleData()
        {
            LoadPeopleData();
        }
        private void frmManagePerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            PersonEvents.PersonChanged -= RefreshPeopleData;
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
            lblRecCount.Text = dgvPerson.Rows.Count.ToString();
        }

        private void tsmiShowDetails_Click(object sender, EventArgs e)
        {
            int personID = (int)dgvPerson.CurrentRow.Cells[0].Value;
            frmPersonDetails form = new frmPersonDetails(personID);
            form.ShowDialog();
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
            int personID = (int)dgvPerson.CurrentRow.Cells[0].Value;
            clsPerson.DeletePerson(personID);
        }

        private void tsmiSendEmailToPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Send Email To Person");
        }

        private void tsmiPhoneCallPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phone Call Person");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Person");
        }

    }
}
