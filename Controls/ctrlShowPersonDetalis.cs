using System.Windows.Forms;
using DVLD_BusinessLayer;

namespace DVLD_PresentationLayer.Controls
{
    public partial class ctrlShowPersonDetalis : UserControl
    {
        private clsPerson _Person;

        public ctrlShowPersonDetalis(int PersonID)
        {
        
            _Person = clsPerson.GetPersonByID(PersonID);

            InitializeComponent();
        }
    }
}
