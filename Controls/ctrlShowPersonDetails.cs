using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_PresentationLayer.Controls
{
    public partial class ctrlShowPersonDetails : UserControl
    {
        private clsPerson _Person;

        public ctrlShowPersonDetails()
        {
            InitializeComponent();
        }     
        public void loadInformation(int PersonID)
        {
            _Person = clsPerson.GetPersonByID(PersonID);
            if (_Person != null)
            {
                lbl_PersonID.Text = _Person.PersonID.ToString();
                lbl_Name.Text = _Person.FirstName + _Person.SecondName + _Person.ThirdName + _Person.LastName;
                lbl_NationalNo.Text = _Person.NationalNo;
                lbl_Gendor.Text = _Person.Gendor ? "Male":"FeMale";
                lbl_Email.Text = _Person.Email;
                lbl_Address.Text = _Person.Address;
                lbl_Phone.Text = _Person.Phone;
                lbl_DateOfBirth.Text = _Person.DateOfBirth.ToString();
                lbl_Country.Text = clsCountry.GetNameByID( _Person.NationalityCountryID);
            }
        }

    }
}
