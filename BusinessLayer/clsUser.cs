using System;
using DVLD_DataAccessLayer;
using DVLD_DataAccessLayer.Dtos;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public clsUser() 
        {
            UserID = -1;
            PersonID = -1;
            UserName = string.Empty;
            Password = string.Empty;
            IsActive = false;
        }

        public clsUser(UserDto userDto)
        {
            UserID = userDto.UserID;
            PersonID = userDto.PersonID;
            UserName = userDto.UserName;
            Password = userDto.Password;
            IsActive = userDto.IsActive;
        }

        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            IsActive = isActive;
        }

        public static clsUser Find(string UserName, string Password)
        {
            if (clsDataAccessUser.FindUser(UserName, Password, out UserDto userDto))
            {
                return new clsUser(userDto);
            }
            return null;
        }
    }
}
