using System;

namespace PharmacyManagementSystem
{
    internal class PharmacistsClass
    {
        internal int PharmacistsId
        {
            get;
            set;
        }
        internal string PharmacistsFirstName
        {
            get;
            set;
        }
        internal string PharmacistsLastName
        {
            get;
            set;
        }
        internal DateTime PharmacistsDateOfBirth
        {
            get;
            set;
        }
        internal string PharmacistsGender
        {
            get;
            set;
        }
        internal string PharmacistsContact
        {
            get;
            set;
        }
        internal double PharmacistsSalary
        {
            get;
            set;
        }
        internal string PharmacistsUsername
        {
            get;
            set;
        }
        internal string PharmacistsPassword
        {
            get;
            set;
        }


        internal PharmacistsClass(int pharmacistsId, string pharmacistsFirstName, string pharmacistsLastName, DateTime pharmacistsDob, string pharmacistsGender,
            string pharmacistsContact, double pharmacistsSalary, string pharmacistsUsername, string pharmacistsPassword)
        {
            this.PharmacistsId = pharmacistsId;
            this.PharmacistsFirstName = pharmacistsFirstName;
            this.PharmacistsLastName = pharmacistsLastName;
            this.PharmacistsDateOfBirth = pharmacistsDob;
            this.PharmacistsGender = pharmacistsGender;
            this.PharmacistsContact = pharmacistsContact;
            this.PharmacistsSalary = pharmacistsSalary;
            this.PharmacistsUsername = pharmacistsUsername;
            this.PharmacistsPassword = pharmacistsPassword;
        }
    }
}