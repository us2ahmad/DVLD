using DVLD_DataAccessLayer.Dtos;
using System;
using System.Data;
using System.Data.SqlClient;

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
    
        public static int AddPerson(PersonDto personDto)
        {
            int personID = -1;
            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery = 
                "INSERT INTO [People] " +
                "([NationalNo],[FirstName],[SecondName],[ThirdName],[LastName],[DateOfBirth],[Gendor],[Address],[Phone],[Email],[NationalityCountryID],[ImagePath]) " +
                "VALUES(@NationalNo,@FirstName,@SecondName,@ThirdName,@LastName,@DateOfBirth,@Gendor,@Address,@Phone,@Email,@NationalityCountryID,@ImagePath); " +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@NationalNo", personDto.NationalNo ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@FirstName", personDto.FirstName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@SecondName", personDto.SecondName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@ThirdName", personDto.ThirdName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@LastName", personDto.LastName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", personDto.DateOfBirth);
            sqlCommand.Parameters.AddWithValue("@Gendor", personDto.Gendor );
            sqlCommand.Parameters.AddWithValue("@Address", personDto.Address ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Phone", personDto.Phone ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@NationalityCountryID", personDto.NationalityCountryID);
            sqlCommand.Parameters.AddWithValue("@ImagePath", personDto.ImagePath ?? (object)DBNull.Value);

            try
            {
                sqlConnection.Open();
                object result = sqlCommand.ExecuteScalar();
                if(result != null && int.TryParse(result.ToString(),out int personId))
                {
                    personID = personId;
                }
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return personID;
        }

        public static bool UpdatePerson(int personID, PersonDto personDto)
        {
            int rowsAffected = 0;

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery =
                "UPDATE [People] SET " +
                "[NationalNo] = @NationalNo, " +
                "[FirstName] = @FirstName, " +
                "[SecondName] = @SecondName, " +
                " [ThirdName] = @ThirdName, " +
                "[LastName] = @LastName, " +
                "[DateOfBirth] = @DateOfBirth," +
                "[Gendor] = @Gendor, " +
                "[Address] = @Address, " +
                "[Phone] = @Phone, " +
                "[Email] = @Email, " +
                "[NationalityCountryID] = @NationalityCountryID, " +
                "[ImagePath] = @ImagePath " +
                "WHERE PersonID = @PersonID ";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", personID);
            sqlCommand.Parameters.AddWithValue("@NationalNo", personDto.NationalNo ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@FirstName", personDto.FirstName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@SecondName", personDto.SecondName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@ThirdName", personDto.ThirdName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@LastName", personDto.LastName ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@DateOfBirth", personDto.DateOfBirth);
            sqlCommand.Parameters.AddWithValue("@Gendor", personDto.Gendor);
            sqlCommand.Parameters.AddWithValue("@Address", personDto.Address ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@Phone", personDto.Phone ?? (object)DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@NationalityCountryID", personDto.NationalityCountryID);
            sqlCommand.Parameters.AddWithValue("@ImagePath", personDto.ImagePath ?? (object)DBNull.Value);

            try
            {
                sqlConnection.Open();
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                rowsAffected = 0;
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return (rowsAffected > 0);
        }


        public static bool DeletePerson(int personID)
        {
            int rowsAffected = 0;

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string sqlQuery =
                "DELETE FROM [People] WHERE PersonID = @PersonID ";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                sqlConnection.Open();
                rowsAffected = sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                sqlConnection.Close();
            }
            return (rowsAffected > 0);
        }
    }
}
