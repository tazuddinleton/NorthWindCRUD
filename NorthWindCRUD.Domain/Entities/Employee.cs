using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindCRUD.Domain
{
    public class Employee
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _title;
        private string _titleOfCourtesy;
        private DateTime _birthDate;
        private DateTime _hireDate;
        private string _address;
        private string _city;
        private string _region;
        private string _postalCode;
        private string _country;
        private string _homePhone;
        private string _extension;
        private byte[] _photo;
        private string _notes;
        private int _reportsTo;
        private string _photoPath;

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public string TitleOfCourtesy
        {
            get => _titleOfCourtesy;
            set => _titleOfCourtesy = value;
        }
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }
        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public string City
        {
            get => _city;
            set => _city = value;
        }
        public string Region
        {
            get => _region;
            set => _region = value;
        }
        public string PostalCode
        {
            get => _postalCode;
            set => _postalCode = value;
        }
        public string Country
        {
            get => _country;
            set => _country = value;
        }
        public string HomePhone
        {
            get => _homePhone;
            set => _homePhone = value;
        }
        public string Extension
        {
            get => _extension;
            set => _extension = value;
        }
        public byte[] Photo
        {
            get => _photo;
            set => _photo = value;
        }
        public string Notes
        {
            get => _notes;
            set => _notes = value;
        }
        public int ReportsTo
        {
            get => _reportsTo;
            set => _reportsTo = value;
        }
        public string PhotoPath
        {
            get => _photoPath;
            set => _photoPath = value;
        }
    }
}
