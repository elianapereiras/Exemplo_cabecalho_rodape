using Microsoft.AspNetCore.Mvc;

namespace Exemplo_cabecalho_rodape.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult Solicitar()
        {
            return View();
        }
    }
}
