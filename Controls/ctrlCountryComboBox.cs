using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer.Controls
{
    public partial class ctrlCountryComboBox : UserControl
    {
        public ctrlCountryComboBox()
        {
            InitializeComponent();
        }
        public int? SelectedCountryId
        {
            get
            {
                if (cbCountries.SelectedValue != null)
                    return Convert.ToInt32(cbCountries.SelectedValue);
                return null;
            }
            set
            {
                cbCountries.SelectedValue = value;
            }
        }

        public string SelectedCountryName
        {
            get
            {
                return cbCountries.Text;
            }
        }

        public void LoadCountries()
        {
            if (!DesignMode) 
            {
                DataTable dt = clsCountry.GetAllCountry();

                cbCountries.DataSource = dt;
                cbCountries.DisplayMember = "CountryName"; 
                cbCountries.ValueMember = "CountryID";    
                cbCountries.SelectedIndex = -1; 
            }
        }
    }
}
