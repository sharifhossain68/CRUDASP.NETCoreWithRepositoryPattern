using Microsoft.AspNetCore.Mvc;

namespace CRUDASP.NETCoreWithRepositoryPattern.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
