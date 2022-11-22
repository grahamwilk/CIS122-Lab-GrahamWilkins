using Mayflower_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mayflower_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            FileGateWay aGateway = new FileGateWay();
            List<Person> aListOfPeople = new List<Person>();
            aListOfPeople = aGateway.GetPeople("C:\\Users\\elaco\\Documents\\Mayflower.csv");
            ViewBag.ListOfPeople = aListOfPeople;
            return View();
        }
    }
}
