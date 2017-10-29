using System.Web.Mvc;

namespace WebForYouUI.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult StartPage()
        {
            return View();
        }
    }
}