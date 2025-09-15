using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDataAccessCountry
    {
        public static DataTable GetAllCountry()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery = "SELECT * FROM Countries";
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

        public static string GetNameByID(int countryID)
        {
            string countryName = string.Empty;
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery = "SELECT CountryName FROM Countries WHERE CountryID = @CountryID";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@CountryID", countryID);

            try
            {
                sqlConnection.Open();

                object result = sqlCommand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    countryName = result.ToString();
                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
            return countryName;
        }
    }
}
