using Microsoft.AspNetCore.Mvc;
using northwind_app.Models;

namespace northwind_app.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FileGateway aGateway = new FileGateway();
            List<Supplier> aListOfSuppliers = aGateway.GetSuppliers("C:\\Users\\elaco\\Documents\\Suppliers.csv");
            ViewBag.ListOfSuppliers = aListOfSuppliers;
            List<Shipper> aListOfShippers = aGateway.GetShippers("C:\\Users\\elaco\\Documents\\Shippers.csv");
            ViewBag.ListOfShippers = aListOfShippers;
            List<Product> aListOfProducts = aGateway.GetProducts("C:\\Users\\elaco\\Documents\\Products.csv");
            ViewBag.ListOfProducts = aListOfProducts;
            List<OrderDetail> aListOfOrderDetails = aGateway.GetOrderDetails("C:\\Users\\elaco\\Documents\\Order Details.csv");
            ViewBag.ListOfOrderDetails = aListOfOrderDetails;
            // There is no CSV file yet for Orders, so we won't run this code until we have one.
            //List<Order> aListOfOrders = aGateway.GetOrders("C:\\Users\\elaco\\Documents\\Order.csv");
            //ViewBag.ListOfOrders = aListOfOrders;
            List<Employee> aListOfEmployees = aGateway.GetEmployees("C:\\Users\\elaco\\Documents\\Employees.csv");
            ViewBag.ListOfEmployees = aListOfEmployees;
            // There is no CSV file yet for Orders, so we won't run this code until we have one.
            //List<Customer> aListOfCustomers = aGateway.GetCustomers("C:\\Users\\elaco\\Documents\\Employees.csv");
            //ViewBag.ListOfCustomers = aListOfCustomers;
            List<Category> aListOfCategories = aGateway.GetCategories("C:\\Users\\elaco\\Documents\\Categories.csv");
            ViewBag.ListOfCategories = aListOfCategories;

            return View();
        }
    }
}
