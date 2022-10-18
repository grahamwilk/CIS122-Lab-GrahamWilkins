// Graham Wilkins
// 8/26/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace northwind_app.Models
{
    public class Customer
    {
        // class variables
        private string customerId = "-00000";
        private string companyName = "n/a";
        private string contactName = "n/a";
        private string contactTitle = "n/a";
        private string address = "n/a";
        private string city = "n/a";
        private string region = "n/a";
        private string postalCode = "n/a";
        private string country = "n/a";
        private string phone = "n/a";
        private string fax = "n/a";

        // gets and sets
        public string CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }
        public string CompanyName
        {
            get { return this.companyName; }
            set { this.companyName = value; }
        }
        public string ContactName
        {
            get { return this.contactName; }
            set { this.contactName = value; }
        }
        public string ContactTitle
        {
            get { return this.contactTitle; }
            set { this.contactTitle = value; }
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
        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Fax
        {
            get { return this.fax; }
            set { this.fax = value; }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Customer Id: " + this.CustomerId + "\n";
            message += "Company Name: " + this.CompanyName + "\n";
            message += "Contact Name: " + this.ContactName + "\n";
            message += "Contact Title: " + this.ContactTitle + "\n";
            message += "Address: " + this.Address + "\n";
            message += "City: " + this.City + "\n";
            message += "Region: " + this.Region + "\n";
            message += "Postal Code: " + this.PostalCode + "\n";
            message += "Country: " + this.Country + "\n";
            message += "Phone: " + this.Phone + "\n";
            message += "Fax: " + this.Fax + "\n";
            return message;
        }
        public Customer(string customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            CustomerId = customerId;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
        }
        public Customer() :
            this("-00000", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
    }
}
