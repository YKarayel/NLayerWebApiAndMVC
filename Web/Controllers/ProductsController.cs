using Microsoft.AspNetCore.Mvc;

namespace NLayer.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
 