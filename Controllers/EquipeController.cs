using EJOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace EJOGOS.Controllers
{
    public class EquipeController : Controller
    {

        //ActionResult representa os varios codigos HTTP,
        //Codigos HTTP - https://developer.mozilla.org/pt-br/docs/Web/HTTP/Status
        Equipe equipeModel = new Equipe();

        public IActionResult Index()
        {
            //ViewBag = reserva de espaço para armazenar informações ára recuperar na View.
            //Viewbag = tem a função de "carregar' as informações do Controller para a View.

            ViewBag.Equipes = equipeModel.LerEquipes();



            return View();

        }
    }
}
