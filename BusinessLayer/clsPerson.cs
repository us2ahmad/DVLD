using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
     
        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public bool Gendor { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int NationalityCountryID { set; get; }
        public string ImagePath { set; get; }

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = string.Empty;
            FirstName = string.Empty;
            SecondName = string.Empty;
            ThirdName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.Now;
            Gendor = false;
            Address = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            NationalityCountryID = -1;
            ImagePath = string.Empty;
        }

        private clsPerson(int personID, string nationalNo, string firstName, string secondName, string thirdName, 
                    string lastName, DateTime dateOfBirth, bool gendor, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gendor = gendor;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;
        }

        public static clsPerson GetPersonByID(int PersonID)
        {
             string 
                nationalNo = string.Empty, firstName = string.Empty, secondName = string.Empty, 
                thirdName = string.Empty, lastName = string.Empty, phone = string.Empty, address = string.Empty,
                email = string.Empty, imagePath = string.Empty;

            DateTime dateOfBirth = DateTime.Now; bool gendor = false; int nationalityCountryID = -1;

            if (clsDataAccessPerson.GetPersonByID(PersonID, ref nationalNo,ref firstName,ref secondName, ref thirdName, ref lastName
                , ref dateOfBirth, ref gendor, ref address, ref phone, ref email, ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(PersonID,nationalNo,firstName,secondName,thirdName,lastName,dateOfBirth,gendor,
                    address,phone,email,nationalityCountryID,imagePath);
            }
            return null;
        }

        public static DataTable GetAllPerson()
        {
            return clsDataAccessPerson.GetAllPerson();
        }
    }
}
