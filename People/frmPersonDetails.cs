using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Forms.People
{
    public partial class frmPersonDetails : Form
    {
        private int _PersonID = -1;
        public frmPersonDetails(int personID)
        {
            InitializeComponent();
            ctrlShowPersonDetails1.loadInformation(personID);
        }

    }
}
