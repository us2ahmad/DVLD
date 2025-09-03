using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDataAccessPeople
    {

        public static DataTable GetAllPeople()
        {

            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery = 
                "SELECT p.PersonID,p.NationalNo,p.FirstName,p.SecondName,p.ThirdName,p.LastName,p.DateOfBirth," +
                " CASE WHEN p.Gendor = 0 THEN 'Male' ELSE 'FeMale' END AS Gendor ,p.Address,p.Phone,p.Email,c.CountryName" +
                " FROM People p" +
                " INNER JOIN Countries c ON c.CountryID = p.NationalityCountryID";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            
            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader); 
                }
                reader.Close();
             
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();  
            }

            return dt;
        }

    }
}
