using System.Collections.Generic;
using System.Web.Mvc;
using TesteDDLJS.Models;
using System.Linq;

namespace TesteDDLJS.Controllers
{
    public class HomeController : Controller
    {
        protected readonly List<Pessoa> pessoas;

        public HomeController()
        {
            pessoas = new List<Pessoa> 
                { 
                    new Pessoa { ID = 1, Nome = "Raphael Nalin", Sexo = 1 },
                    new Pessoa { ID = 2, Nome = "Fausto Silva", Sexo = 1 },
                    new Pessoa { ID = 6, Nome = "Ademir Pereira", Sexo = 1 },
                    new Pessoa { ID = 8, Nome = "Fabiano Nalin", Sexo = 1 },
                    new Pessoa { ID = 10, Nome = "Rubens dos Santos", Sexo = 1 },
                    new Pessoa { ID = 3, Nome = "Priscila Nalin", Sexo = 0 },
                    new Pessoa { ID = 4, Nome = "Marcia Silva", Sexo = 0 },
                    new Pessoa { ID = 5, Nome = "Stephanie Santos", Sexo = 0 },
                    new Pessoa { ID = 7, Nome = "Renata Pereira", Sexo = 0 },
                     new Pessoa { ID = 9, Nome = "Fernanda dos Santos Pereira da Silva", Sexo = 0 }
                };
        }

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult RetornadaLista(int sexo)
        {

            //add perfumaria um tempo de espera para exibir um loader na tela
            System.Threading.Thread.Sleep(2000);

            return Json(GetPessoas(sexo), JsonRequestBehavior.AllowGet);
        }

        private List<Pessoa> GetPessoas(int sexo)
        {

            return pessoas.Where(d => d.Sexo == sexo).OrderBy(d => d.Nome).ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo - TesteDDLJS";
            return View();
        }

    }
}