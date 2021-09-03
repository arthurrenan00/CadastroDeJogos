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
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = new Cliente();
            return View(cliente);
        }
        Acoes ac = new Acoes();

        [HttpPost]
        public ActionResult Index(Cliente cliente)
        {
            ac.CadastrarCliente(cliente);
            return View(cliente);
        }

        public ActionResult ListCli(Cliente cliente)
        {
            return View(cliente);
        }

        public ActionResult Cpf_Cli_Uni(string cpfcliente)
        {
            var bdcliente = new Collection<string>
            {
                "111.222.333-44",
                "222.333.444-55"
            };

            return Json(bdcliente.All(x => x.ToLower() != cpfcliente.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}