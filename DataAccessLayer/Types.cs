using System;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    internal static class Types
    {
        public static string GetString(SqlDataReader reader, string columnName)
        {
            return reader[columnName] == DBNull.Value ? string.Empty : reader[columnName].ToString();
        }

        public static int GetInt(SqlDataReader reader, string columnName)
        {
            return reader[columnName] == DBNull.Value ? 0 : Convert.ToInt32(reader[columnName]);
        }

        public static bool GetBool(SqlDataReader reader, string columnName)
        {
            return reader[columnName] == DBNull.Value ? false : Convert.ToBoolean(reader[columnName]);
        }
        public static DateTime GetDateTime(SqlDataReader reader, string columnName)
        {
            return reader[columnName] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader[columnName]);
        }

    }
}
