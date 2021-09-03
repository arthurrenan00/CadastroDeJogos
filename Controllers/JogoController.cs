using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroJogos.Models;
using System.Collections.ObjectModel;
using CadastroJogos.Repositorio;

namespace CadastroJogos.Controllers
{
    public class JogoController : Controller
    {
        // GET: Jogo
        public ActionResult Index()
        {
            var jogo = new Jogo();
            return View(jogo);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Index(Jogo jogo)
        {
            ac.CadastrarJogo(jogo);
            return View(jogo);
        }

        public ActionResult ListJogo(Jogo jogo)
        {
            return View(jogo);
        }

        public ActionResult Cod_J_Unico(string codj)
        {
            var bdjogo = new Collection<string>
            {
                "11111111",
                "22222222",
                "33333333"
            };

            return Json(bdjogo.All(x => x.ToLower() != codj.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}