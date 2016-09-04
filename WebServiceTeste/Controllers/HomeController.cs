using System.Web.Mvc;
using WebServiceTeste.Models;

namespace WebServiceTeste.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Endereco cep)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            using (var correios = new Correios.AtendeClienteClient())
            {
                var consulta = correios.consultaCEP(cep.Cep.Replace("-", ""));

                if (consulta != null)
                {
                    ViewBag.Endereco = new Endereco
                    {
                        Descricao = consulta.end,
                        Complemento = consulta.complemento,
                        Bairro = consulta.bairro,
                        Cidade = consulta.cidade,
                        Estado = consulta.uf
                    };
                }
            }
            return View(cep);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}