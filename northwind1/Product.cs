// Graham Wilkins
// 8/29/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_northwind_part_1
{
    public class Product
    {
        // class variables
        private int productId = -1;
        private string productName = "n/a";
        private int supplierId = -1;
        private int categoryId = -1;
        private string quantityPerUnit = "n/a";
        private double unitPrice = double.MaxValue;
        private int unitsInStock = -1;
        private int unitsOnOrder = -1;
        private int reorderLevel = int.MaxValue;
        private bool discontinued = true;

        // gets and sets
        public int ProductId
        {
            get { return productId; }
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
        public string ProductName
        {
            get { return productName; }
            set { this.productName = value; }
        }
        public int SupplierId
        {
            get { return supplierId; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.supplierId = value;
                }
                else
                {
                    this.supplierId = 0;
                }
            }
        }
        public int CategoryId
        {
            get { return categoryId; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.categoryId = value;
                }
                else
                {
                    this.categoryId = 0;
                }
            }
        }
        public string QuantityPerUnit
        {
            get { return quantityPerUnit; }
            set { quantityPerUnit = value; }
        }
        public double UnitPrice
        {
            get { return this.unitPrice; }
            set
            {
                // must be greater than 0.0
                if (value >= 0.0)
                {
                    this.unitPrice = value;
                }
                else
                {
                    this.unitPrice = double.MaxValue;
                }
            }
        }
        public int UnitsInStock
        {
            get { return unitsInStock; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.unitsInStock = value;
                }
                else
                {
                    this.unitsInStock = 0;
                }
            }
        }
        public int UnitsOnOrder
        {
            get { return unitsOnOrder; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.unitsOnOrder = value;
                }
                else
                {
                    this.unitsOnOrder = 0;
                }
            }
        }
        public int ReorderLevel
        {
            get { return reorderLevel; }
            set
            {
                // must be greater than -1
                if (value >= -1)
                {
                    this.reorderLevel = value;
                }
                else
                {
                    this.reorderLevel = 0;
                }
            }
        }
        public bool Discontinued
        {
            get { return discontinued; }
            set { this.discontinued = value; }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Product Id: " + this.ProductId + "\n";
            message += "Product Name: " + this.ProductName + "\n";
            message += "Supplier Id: " + this.SupplierId + "\n";
            message += "Category Id: " + this.CategoryId + "\n";
            message += "Quantity Per Unit: " + this.QuantityPerUnit + "\n";
            message += "Unit Price: " + this.UnitPrice + "\n";
            message += "Units in Stock: " + this.UnitsInStock + "\n";
            message += "Units on Order: " + this.UnitsOnOrder + "\n";
            message += "Reorder Level: " + this.ReorderLevel + "\n";
            message += "Discontinued: " + this.Discontinued + "\n";
            return message;
        }
        public Product(int productId, string productName, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitsInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            ProductId = productId;
            ProductName = productName;
            SupplierId = supplierId;
            CategoryId = categoryId;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
        }
        public Product() :
            this(-1, "n/a", -1, -1, "n/a", double.MaxValue, -1, -1, int.MaxValue, true)
        {

        }
    }
}
