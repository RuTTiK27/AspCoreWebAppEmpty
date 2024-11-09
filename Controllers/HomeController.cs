using Microsoft.AspNetCore.Mvc; //Controller comes from this namespace


namespace AspCoreWebAppEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //--ViewData--
            ViewData["data"] = "Hello, ";
            ViewData["username"] = "Rutvik";
            ViewData["datetime"] = DateTime.Now.ToLongDateString();
            
            string[] names = { "Rutvik", "Krupal", "Kaka" };
            ViewData["arr"] = names;

            List<string> sports = new List<string>() { "Cricket", "Football", "Hocky"};
            ViewData["sports"] = sports;

            Dictionary<string, int> usersDirectory = new Dictionary<string, int>
            {
                { "Rutvik",1 },
                { "Krupal",2 },
                { "Kaka",3 }
            };
            ViewData["dictionaryExample"] = usersDirectory;
            //--ViewBag--
            ViewBag.data = "Test data for viewbag";
            ViewBag.shortDate = DateTime.Now.ToShortDateString();
            ViewBag.names = names;
            ViewBag.users = usersDirectory;

            ViewData["myName"] = "Rutvik"; //but i will call this as ViewBag.myName

            TempData["tempData"] = "Temp Data";
            TempData.Keep("tempData");
            return View();
        }
        public IActionResult About() 
        {
            TempData.Keep("tempData");
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
