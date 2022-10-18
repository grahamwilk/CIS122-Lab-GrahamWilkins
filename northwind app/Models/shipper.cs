// Graham Wilkins
// 8/29/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace northwind_app.Models
{
    public class Shipper
    {
        // class variables
        private int shipperId = -1;
        private string companyName = "n/a";
        private string phone = "n/a";

        // gets and sets
        public int ShipperId
        {
            get { return shipperId; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.shipperId = value;
                }
                else
                {
                    this.shipperId = 0;
                }
            }
        }
        public string CompanyName
        {
            get { return companyName; }
            set { this.companyName = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Shipper Id: " + this.ShipperId + "\n";
            message += "Company Name: " + this.CompanyName + "\n";
            message += "Phone: " + this.Phone + "\n";
            return message;
        }
        public Shipper(int shipperId, string companyName, string phone)
        {
            ShipperId = shipperId;
            CompanyName = companyName;
            Phone = phone;
        }
        public Shipper() :
            this(-1, "n/a", "n/a")
        {
            // empty constructor
        }
    }
}
