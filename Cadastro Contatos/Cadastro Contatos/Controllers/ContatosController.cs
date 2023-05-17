using Cadastro_Contatos.Models;
using Cadastro_Contatos.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro_Contatos.Controllers
{
    public class ContatosController : Controller
    {
        readonly private ApplicationDbContext _db;
        public ContatosController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ContatosModel> contatos = _db.Contatos;
            return View(contatos);
        }
    }
}
