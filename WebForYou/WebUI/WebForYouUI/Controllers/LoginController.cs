using System.Web.Mvc;
using WebForYouUI.Infrastructure.Abstract;
using WebForYouUI.Infrastructure.Concrete;

namespace WebForYouUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAuthProvider _authProvider;
        public LoginController(IAuthProvider authProvider)
        {
            _authProvider = authProvider;
        }

        public ActionResult ToAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ToAdmin(AuthenticationModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (_authProvider.Authenticate(model.Name, model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("StartPage", "Admin"));
                }
                ModelState.AddModelError("", "Неправильный логин или пароль");
                return View();
            }
            return View();
        }
        
    }
}