using DVLD_BusinessLayer.Events;
using DVLD_DataAccessLayer;
using DVLD_DataAccessLayer.Dtos;
using System;
using System.Data;
using System.Net;
using System.Security.Policy;

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
        private enMode _Mode { get; set; }


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
            _Mode = enMode.Add;
        }

        public clsPerson(PersonDto personDto)
        {
            PersonID = personDto.PersonID;
            NationalNo = personDto.NationalNo;
            FirstName = personDto.FirstName;
            SecondName = personDto.SecondName;
            ThirdName = personDto.ThirdName;
            LastName = personDto.LastName;
            DateOfBirth = personDto.DateOfBirth;
            Gendor = personDto.Gendor;
            Address = personDto.Address;
            Phone = personDto.Phone;
            Email = personDto.Email;
            NationalityCountryID = personDto.NationalityCountryID;
            ImagePath = personDto.ImagePath;
            _Mode = enMode.Update;
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



        private bool _AddNewPerson()
        {
            PersonDto personDto = new PersonDto
            { 
                PersonID = this.PersonID,
                NationalNo = this.NationalNo,
                FirstName = this.FirstName,
                SecondName = this.SecondName,
                ThirdName = this.ThirdName,
                LastName = this.LastName,
                DateOfBirth = this.DateOfBirth,
                Gendor = this.Gendor,
                Address = this.Address,
                Phone = this.Phone,
                Email = this.Email,
                NationalityCountryID = this.NationalityCountryID,
                ImagePath = this.ImagePath,
            };

            this.PersonID = clsDataAccessPerson.AddPerson(personDto);

            return this.PersonID != -1;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        if (_AddNewPerson())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                case enMode.Update:
                    {
                        return false; //_UpdateContact();
                    }
            }

            return false;
        }
        public static clsPerson GetPersonByID(int PersonID)
        {
            if (clsDataAccessPerson.GetPersonByID(PersonID,out PersonDto personDto))
            {
                return new clsPerson(personDto);
            }
            return null;
        }

        public static DataTable GetAllPerson()
        {
            return clsDataAccessPerson.GetAllPerson();
        }

        public static bool DeletePerson(int personID)
        {
            bool deleted = clsDataAccessPerson.DeletePerson(personID);
            if (deleted)
            {
                PersonEvents.OnPersonChanged();
            }
            return deleted;
        }
    }
}
