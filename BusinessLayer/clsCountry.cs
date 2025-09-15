using DVLD_DataAccessLayer;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsCountry
    {
        public int CountryID {  get; set; }
        public string Name {  get; set; }

        public static DataTable GetAllCountry()
        {
            return clsDataAccessCountry.GetAllCountry();
        }
        public static string GetNameByID(int countryID)
        {
            return clsDataAccessCountry.GetNameByID(countryID);
        }
    }
}
