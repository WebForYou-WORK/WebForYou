using System.Web.Mvc;
using Domain.Abstrac;
using Domain.Entityes;

namespace WebForYouUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IBlogPhotoRepossitory _blogPhotoRepossitory;
        private readonly ICalcSite _calcSite;
        private readonly IModuleCategoryes _moduleCategoryes;
        private readonly IOrderSite _orderSite;
        private readonly ISliderOfWoks _sliderOfWoks;
        public HomeController(IBlogPhotoRepossitory blogPhotoRepossitory, IBlogRepository blogRepository,
            ICalcSite calcSite, IModuleCategoryes moduleCategoryes, IOrderSite orderSite, ISliderOfWoks sliderOfWoks)
        {
            _blogRepository = blogRepository;
            _blogPhotoRepossitory = blogPhotoRepossitory;
            _calcSite = calcSite;
            _moduleCategoryes = moduleCategoryes;
            _orderSite = orderSite;
            _sliderOfWoks = sliderOfWoks;
        }

       

        public ViewResult StartPage()
        {
            return View();
        }
    }
}