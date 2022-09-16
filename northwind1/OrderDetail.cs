// Graham Wilkins
// 8/26/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_northwind_part_1
{
    public class OrderDetail
    {
        // class variables
        private int orderId = -1;
        private int productId = -1;
        private double unitPrice = double.MaxValue;
        private int quantity = 0;
        private double discount = 0.0;

        // gets and sets
        public int OrderId
        {
            get { return this.orderId; }
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
        public int ProductId
        {
            get { return this.productId; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.productId = value;
                }
                else
                {
                    this.productId = 0;
                }
            }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                // must be greater than 0.0
                if (value >= 0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = double.MaxValue;
                }
            }
        }
        public int Quantity
        {
            get { return this.quantity; }
            set
            {
                // must be greater than 0
                if (value >= 0)
                {
                    this.quantity = value;
                }
                else
                {
                    this.quantity = 0;
                }
            }
        }
        public double Discount
        {
            get { return this.discount; }
            set
            {
                // must be greater than 0
                if (value >= 0)
                {
                    this.discount = value;
                }
                else
                {
                    this.discount = 0.0;
                }
            }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Order Id: " + this.OrderId + "\n";
            message += "Product Id: " + this.ProductId + "\n";
            message += "Unit Price: " + this.UnitPrice + "\n";
            message += "Quantity: " + this.Quantity + "\n";
            message += "Discount: " + this.Discount + "\n";
            return message;
        }
        public OrderDetail(int orderId, int productId, double unitPrice, int quantity, double discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }
        public OrderDetail() :
            this(-1, -1, double.MaxValue, 0, 0.0)
        {

        }
    }
}
