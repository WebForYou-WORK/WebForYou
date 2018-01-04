using System.Linq;
using System.Web.Mvc;
using Domain.Abstrac;

namespace WebForYouUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public ActionResult OllNews()
        {
            return View(_blogRepository.Blogs.OrderByDescending(x=>x.NewsDateCreate));
        }

    }
}