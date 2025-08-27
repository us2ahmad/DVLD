using System;
using DVLD_DataAccessLayer;

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

        public clsUser(int UserID, int PersonID, string UserName,string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;
        }


        public static clsUser Find(string UserName, string Password)
        {
            int UserID = -1, PersonID= -1;
            bool IsActive = false;

            if (clsDataAccessUser.FindUser(UserName, Password,ref UserID, ref PersonID, ref IsActive))
            {
                return new clsUser(UserID, PersonID, UserName, Password,IsActive);
            }

            return null;
        }

    }
}
