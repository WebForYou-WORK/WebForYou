using System.Linq;
using System.Web.Mvc;
using Domain.Abstrac;

namespace WebForYouUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderOfWoks _sliderOfWoks;
        private readonly IShares _shares;
        public HomeController(ISliderOfWoks sliderOfWoks, IShares shares)
        {
            _sliderOfWoks = sliderOfWoks;
            _shares = shares;
        }

        public ViewResult StartPage()    //Стартовая для дендинга
        {
            return View(_sliderOfWoks.SliderOfWorks.OrderBy(x=>x.PrioritySlide));
        }

        public ViewResult SiteServices()   // Перечень услуг по сайтам
        {
            return View();
        }

        public ViewResult DesignServices()   // Перечень услуг по дизайну
        {
            return View();
        }
        public ViewResult SeoServices()   // Перечень услуг по SEO
        {
            return View();
        }
        public ViewResult SmmServices()   // Перечень услуг по SMM
        {
            return View();
        }
        public ViewResult SoftwareServices()   // Перечень услуг по Софту
        {
            return View();
        }
        public ViewResult SupportServices()   // Перечень услуг по поддержке
        {
            return View();
        }
        public ViewResult OurShares() //акции
        {
            return View(_shares.Shareses.OrderByDescending(x=>x.ShareDateCreate));
        }

    }
}