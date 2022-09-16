// Graham Wilkins
// 8/26/22

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_northwind_part_1
{
    public class Category
    {
        // class variables
        private int categoryId = -1;
        private string categoryName = "n/a";
        private string description = "n/a";

        // gets and sets
        public int CategoryId
        {
            get { return this.categoryId; }
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

        public string CategoryName
        {
            get { return this.categoryName; }
            set { this.categoryName = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        // tostring override
        public override string ToString()
        {
            string message = "";
            message += "Category Id: " + this.CategoryId + "\n";
            message += "Category Name: " + this.CategoryName + "\n";
            message += "Description: " + this.Description + "\n";
            return message;
        }
        public Category(int categoryId, string categoryName, string description)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
        }
        public Category() :
            this(-1, "n/a", "n/a")
        {

        }
    }
}
