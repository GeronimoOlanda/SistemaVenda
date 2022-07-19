using Microsoft.AspNetCore.Mvc;
using SistemaVendas.DAL;

namespace SistemaVendas.Controllers
{
    public class CategoriaController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
