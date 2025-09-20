using DVLD_DataAccessLayer.Dtos;
using System;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDataAccessUser
    {
        public static  bool FindUser(string userName,string password ,out UserDto userDto)
        {
            userDto = null;
            bool isFound = false;

            SqlConnection sqlConnection = new SqlConnection(clsDataAccessSettings.ConnectionString);
           
            string sqlQuery = "SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password";

            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserName", userName);
            sqlCommand.Parameters.AddWithValue("@Password", password);

            try
            {
                sqlConnection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    userDto = new UserDto
                    {
                        UserID = Types.GetInt(reader, "UserID"),
                        UserName = Types.GetString(reader, "UserName"),
                        Password = Types.GetString(reader, "Password"),
                        PersonID = Types.GetInt(reader, "PersonID"),
                        IsActive = Types.GetBool(reader, "IsActive")
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
