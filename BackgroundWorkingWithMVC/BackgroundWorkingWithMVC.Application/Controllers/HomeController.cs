using BackgroundWorkingWithMVC.Application.Caching;
using System.Web.Mvc;

namespace BackgroundWorkingWithMVC.Application.Controllers
{
    public class HomeController : Controller
    {
        public CategoriesCachingHelper CategoriesCachingHelper { get; private set; }

        public HomeController(CategoriesCachingHelper categoriesCachingHelper)
        {
            CategoriesCachingHelper = categoriesCachingHelper;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(CategoriesCachingHelper.GetDataFromCache());
        }
    }
}