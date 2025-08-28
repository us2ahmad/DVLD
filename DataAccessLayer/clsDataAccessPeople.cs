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

            string sqlQuery = "SELECT PersonID , NationalNo , FirstName , SecondName , ThirdName , LastName , DateOfBirth , Gendor , Address , Phone , Email FROM People";

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
