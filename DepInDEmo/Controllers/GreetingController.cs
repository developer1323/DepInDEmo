using System.Web.Mvc;
using DepInDEmo.Services;

namespace DepInDEmo.Controllers
{
    public class GreetingController : Controller
    {
        private readonly GreetingService _greetingService;

        public GreetingController()
        {
            _greetingService = new GreetingService();

        }

        // GET: Greeting
        public ActionResult Index()
        {
            ViewData["message"] =  _greetingService.GetGreeting();
            return View();
        }
    }
}