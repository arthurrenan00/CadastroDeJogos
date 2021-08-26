using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.ObjectModel;
using CadastroJogos.Models;

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

        [HttpPost]
        public ActionResult Index(Funcionario func)
        {

            if (ModelState.IsValid)
            {
                return View("ListFunc", func);
            }
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
                "12345678",
                "23456789"
            };
            return Json(bdfunc.All(x => x.ToLower() != codfuncio.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}