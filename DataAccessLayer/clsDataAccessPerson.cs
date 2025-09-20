using DVLD_DataAccessLayer.Dtos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DVLD_DataAccessLayer
{
    public class clsDataAccessPerson
    {

        public static DataTable GetAllPerson()
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

        public static bool GetPersonByID(int PersonID,out PersonDto personDto)
        {
            personDto = null;
            bool isFound = false;
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery = "SELECT * FROM People WHERE PersonID = @PersonID";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery,sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    personDto = new PersonDto
                    {
                        PersonID = Types.GetInt(reader, "PersonID"),
                        NationalNo = Types.GetString(reader, "NationalNo"),
                        FirstName = Types.GetString(reader, "FirstName"),
                        SecondName = Types.GetString(reader, "SecondName"),
                        ThirdName = Types.GetString(reader, "ThirdName"),
                        LastName = Types.GetString(reader, "LastName"),
                        DateOfBirth = Types.GetDateTime(reader, "DateOfBirth"),
                        Gendor = Types.GetBool(reader, "Gendor"),
                        Address = Types.GetString(reader, "Address"),
                        Phone = Types.GetString(reader, "Phone"),
                        Email = Types.GetString(reader, "Email"),
                        NationalityCountryID = Types.GetInt(reader, "NationalityCountryID"),
                        ImagePath = Types.GetString(reader, "ImagePath")
                    };
                   
                    isFound = true;
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

            return isFound;
        }
    }
}
