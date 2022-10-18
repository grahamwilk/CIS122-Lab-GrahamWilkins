// Graham Wilkins
// 10/14/22


using System;
using System.IO;

namespace northwind_app.Models
{
    public class FileGateway
    {
        public List<Supplier> GetSuppliers(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Supplier> aListOfSuppliers = new List<Supplier>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Supplier aSupplier;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aSupplier = new Supplier(Convert.ToInt32(aRow[0]), aRow[1], aRow[2], aRow[3], aRow[4], aRow[5], aRow[6], aRow[7], aRow[8], aRow[9], aRow[10], aRow[11]);
                aListOfSuppliers.Add(aSupplier);
                index = index + 1;
            }

            return aListOfSuppliers;
        }
        public List<Shipper> GetShippers(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Shipper> aListOfShippers = new List<Shipper>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Shipper aShipper;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aShipper = new Shipper(Convert.ToInt32(aRow[0]), aRow[1], aRow[2]);
                aListOfShippers.Add(aShipper);
                index = index + 1;
            }

            return aListOfShippers;
        }
        public List<Product> GetProducts(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Product> aListOfProducts = new List<Product>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Product aProduct;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aProduct = new Product(Convert.ToInt32(aRow[0]), aRow[1], Convert.ToInt32(aRow[2]), Convert.ToInt32(aRow[3]), aRow[4], Convert.ToDouble(aRow[5]), Convert.ToInt32(aRow[6]), Convert.ToInt32(aRow[7]), Convert.ToInt32(aRow[8]), Convert.ToBoolean(aRow[9]));
                aListOfProducts.Add(aProduct);
                index = index + 1;
            }

            return aListOfProducts;
        }
        public List<OrderDetail> GetOrderDetails(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<OrderDetail> aListOfOrderDetails = new List<OrderDetail>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            OrderDetail aOrderDetail;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aOrderDetail = new OrderDetail(Convert.ToInt32(aRow[0]), Convert.ToInt32(aRow[1]), Convert.ToDouble(aRow[2]), Convert.ToInt32(aRow[3]), Convert.ToDouble(aRow[4]));
                aListOfOrderDetails.Add(aOrderDetail);
                index = index + 1;
            }

            return aListOfOrderDetails;
        }
        public List<Order> GetOrders(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Order> aListOfOrders = new List<Order>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Order aOrder;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aOrder = new Order(Convert.ToInt32(aRow[0]), aRow[1], Convert.ToInt32(aRow[2]), aRow[3], aRow[4], aRow[5], Convert.ToInt32(aRow[6]), Convert.ToDouble(aRow[7]), aRow[8], aRow[9], aRow[10], aRow[11], aRow[12], aRow[13]);
                aListOfOrders.Add(aOrder);
                index = index + 1;
            }

            return aListOfOrders;
        }
        public List<Employee> GetEmployees(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Employee> aListOfEmployees = new List<Employee>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Employee aEmployee;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aEmployee = new Employee(Convert.ToInt32(aRow[0]), aRow[1], aRow[2], aRow[3], aRow[4], aRow[5], aRow[6], aRow[7], aRow[8], aRow[9], aRow[10], aRow[11], aRow[12], aRow[13], aRow[15], Convert.ToInt32(aRow[16]));
                aListOfEmployees.Add(aEmployee);
                index = index + 1;
            }

            return aListOfEmployees;
        }
        public List<Customer> GetCustomers(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Customer> aListOfCustomers = new List<Customer>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Customer aCustomer;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aCustomer = new Customer(aRow[0], aRow[1], aRow[2], aRow[3], aRow[4], aRow[5], aRow[6], aRow[7], aRow[8], aRow[9], aRow[10]);
                aListOfCustomers.Add(aCustomer);
                index = index + 1;
            }

            return aListOfCustomers;
        }
        public List<Category> GetCategories(string aPath)
        {
            // In this case Path includes the filename
            // e.g. C:\\MyDocuments\data.csv


            List<Category> aListOfCategories = new List<Category>();
            string[] allRows;
            // Starts at row 1 because we are skipping the header row
            int index = 1;
            string[] aRow;
            Category aCategory;

            allRows = File.ReadAllLines(aPath);

            while (index < allRows.Length)
            {
                aRow = allRows[index].Split(',');
                aCategory = new Category(Convert.ToInt32(aRow[0]), aRow[1], aRow[2]);
                aListOfCategories.Add(aCategory);
                index = index + 1;
            }

            return aListOfCategories;
        }
    }
}
