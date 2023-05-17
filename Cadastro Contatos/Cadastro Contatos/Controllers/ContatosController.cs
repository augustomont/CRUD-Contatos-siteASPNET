using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Contatos.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
