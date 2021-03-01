using Microsoft.AspNetCore.Mvc;

namespace AlugaJogos.Product.Api.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
