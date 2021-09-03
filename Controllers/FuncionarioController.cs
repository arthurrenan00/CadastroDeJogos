using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.ObjectModel;
using CadastroJogos.Models;
using CadastroJogos.Repositorio;

namespace CadastroJogos.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            var func = new Funcionario();
            return View(func);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Index(Funcionario func)
        {

            ac.CadastrarFunc(func);
            return View(func);
        }

        public ActionResult ListFunc(Funcionario func)
        {
            return View(func);
        }

        public ActionResult Cod_Func_Uni(string codfuncio)
        {
            var bdfunc = new Collection<string>
            {
                "kian",
                "calamidade"
            };
            return Json(bdfunc.All(x => x.ToLower() != codfuncio.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}