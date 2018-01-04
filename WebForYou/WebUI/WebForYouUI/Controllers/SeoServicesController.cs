using System.Web.Mvc;

namespace WebForYouUI.Controllers
{
    public class SeoServicesController : Controller
    {
        // GET: SeoServices
        public ViewResult SeoAnalysis() // сео анализ
        {
            return View();
        }
        public ViewResult SeoOptimization() //сео оптимизация
        {
            return View();
        }
        public ViewResult SeoPromotion() // сео продвижение
        {
            return View();
        }
        public ViewResult AdvertisingPromotion() // Рекламное продвижение
        {
            return View();
        }
    }
}