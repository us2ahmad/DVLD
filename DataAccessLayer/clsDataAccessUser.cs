using System;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public class clsDataAccessUser
    {
        public static  bool FindUser(string userName,string password,ref int UserID,ref int PersonID, ref bool IsActive)
        {
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
                    isFound = true;
                    UserID = Types.GetInt(reader, "UserID");
                    PersonID = Types.GetInt(reader, "PersonID");
                    IsActive = Types.GetBool(reader, "IsActive");
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
