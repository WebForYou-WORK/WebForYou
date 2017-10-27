using System.Web.Mvc;

namespace WebForYouUI.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        public ActionResult StartPage()
        {
            return View();
        }
    }
}