// Graham Wilkins
// 8/26/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_northwind_part_1
{
    public class Employee
    {
        // class variables
        private int employeeId = -1;
        private string lastName = "n/a";
        private string firstName = "n/a";
        private string title = "n/a";
        private string titleOfCourtesy = "n/a";
        private string birthDate = "n/a";
        private string hireDate = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string homePhone = "n/a";
        private string extension = "n/a";
        private string notes = "n/a";
        private int reportsTo = -1;

        // gets and sets
        public int EmployeeId
        {
            get { return this.employeeId; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.employeeId = value;
                }
                else
                {
                    this.employeeId = 0;
                }

            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string TitleOfCourtesy
        {
            get { return this.titleOfCourtesy; }
            set { this.titleOfCourtesy = value; }
        }
        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }
        public string HireDate
        {
            get { return this.hireDate; }
            set { this.hireDate = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Region
        {
            get { return this.region; }
            set { this.region = value; }
        }
        public string PostalCode
        {
            get { return this.postalCode; }
            set { this.postalCode = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string HomePhone
        {
            get { return this.homePhone; }
            set { this.homePhone = value; }
        }
        public string Extension
        {
            get { return this.extension; }
            set { this.extension = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.Notes = value; }
        }
        public int ReportsTo
        {
            get { return this.reportsTo; }

            set
            {
                if (value >= -1)
                {
                    this.reportsTo = value;
                }
                else
                {
                    this.reportsTo = 0;
                }

            }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Employee Id: " + this.EmployeeId + "\n";
            message += "Last Name: " + this.LastName + "\n";
            message += "First Name: " + this.FirstName + "\n";
            message += "Title: " + this.Title + "\n";
            message += "Title of Courtesy: " + this.TitleOfCourtesy + "\n";
            message += "Birth Date: " + this.BirthDate + "\n";
            message += "Hire Date: " + this.HireDate + "\n";
            message += "Address: " + this.Address + "\n";
            message += "City: " + this.City + "\n";
            message += "Region: " + this.Region + "\n";
            message += "Postal Code: " + this.PostalCode + "\n";
            message += "Country: " + this.Country + "\n";
            message += "Home Phone: " + this.HomePhone + "\n";
            message += "Extension: " + this.Extension + "\n";
            message += "Notes: " + this.Notes + "\n";
            message += "ReportsTo: " + this.ReportsTo + "\n";
            return message;
        }
        public Employee(int employeeId, string lastName, string firstName, string title, string titleOfCourtesy, string birthDate, string hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, string notes, int reportsTo)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            TitleOfCourtesy = titleOfCourtesy;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            HomePhone = homePhone;
            Extension = extension;
            Notes = notes;
            ReportsTo = reportsTo;
        }
        public Employee() :
            this(-1, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", -1)
        {

        }
    }
}
