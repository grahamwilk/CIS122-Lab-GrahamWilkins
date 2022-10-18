// Graham Wilkins
// 8/29/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace northwind_app.Models
{
    public class Order
    {
        // class variables
        private int orderId = -1;
        private string customerId = "n/a";
        private int employeeId = -1;
        private string orderDate = "n/a";
        private string requiredDate = "n/a";
        private string shippedDate = "n/a";
        private int shipVia = -1;
        private double freight = double.MaxValue;
        private string shipName = "n/a";
        private string shipAddress = "n/a";
        private string shipCity = "n/a";
        private string shipRegion = "n/a";
        private string shipPostalCode = "n/a";
        private string shipCountry = "n/a";

        // get and sets
        public int OrderId
        {
            get { return orderId; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.orderId = value;
                }
                else
                {
                    this.orderId = 0;
                }
            }
        }
        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public int EmployeeId
        {
            get { return employeeId; }
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
        public string OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }
        public string RequiredDate
        {
            get { return requiredDate; }
            set { requiredDate = value; }
        }
        public string ShippedDate
        {
            get { return shippedDate; }
            set { shippedDate = value; }
        }
        public int ShipVia
        {
            get { return shipVia; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.shipVia = value;
                }
                else
                {
                    this.shipVia = 0;
                }
            }
        }
        public double Freight
        {
            get { return this.freight; }
            set
            {
                // must be greater than 0.0
                if (value >= 0.0)
                {
                    this.freight = value;
                }
                else
                {
                    this.freight = double.MaxValue;
                }
            }
        }
        public string ShipName
        {
            get { return shipName; }
            set { shipName = value; }
        }
        public string ShipAddress
        {
            get { return shipAddress; }
            set { shipAddress = value; }
        }
        public string ShipCity
        {
            get { return shipCity; }
            set { shipCity = value; }
        }
        public string ShipRegion
        {
            get { return shipRegion; }
            set { shipRegion = value; }
        }
        public string ShipPostalCode
        {
            get { return shipPostalCode; }
            set { shipPostalCode = value; }
        }
        public string ShipCountry
        {
            get { return shipCountry; }
            set { shipCountry = value; }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Order Id: " + this.OrderId + "\n";
            message += "Customer Id: " + this.CustomerId + "\n";
            message += "Employee Id: " + this.EmployeeId + "\n";
            message += "Order Date: " + this.OrderDate + "\n";
            message += "Required Date: " + this.RequiredDate + "\n";
            message += "Shipped Date: " + this.ShippedDate + "\n";
            message += "Ship Via: " + this.ShipVia + "\n";
            message += "Freight: " + this.Freight + "\n";
            message += "Ship Name: " + this.ShipName + "\n";
            message += "Ship Address: " + this.ShipAddress + "\n";
            message += "Ship City: " + this.ShipCity + "\n";
            message += "Ship Region: " + this.ShipRegion + "\n";
            message += "Ship Postal Code: " + this.ShipPostalCode + "\n";
            message += "Ship Country: " + this.ShipCountry + "\n";
            return message;
        }
        public Order(int orderId, string customerId, int employeeId, string orderDate, string requiredDate, string shippedDate, int shipVia, double freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry)
        {
            OrderId = orderId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            ShipVia = shipVia;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
        }
        public Order() :
            this(-1, "n/a", -1, "n/a", "n/a", "n/a", -1, double.MaxValue, "n/a", "n/a", "n/a", "n/a", "n/a", "n/a")
        {

        }
    }
}
