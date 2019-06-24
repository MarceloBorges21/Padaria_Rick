using Padaria_Rick.Data;
using Padaria_Rick.Models.DAO;
using Padaria_Rick.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padaria_Rick.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            PessoaDAO dao = new PessoaDAO();
            IList<Pessoa> pessoa = dao.Lista();
            return View(pessoa);
       
        }    

        // GET: Pessoa/Create
        [Route("CadastroCliente")]
        public ActionResult Cadastro()
        {
            ViewBag.Pessoa = new Pessoa();
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]       
        public ActionResult AdicionaCliente(Pessoa pessoa)
        {          
                if (ModelState.IsValid)
                {
                    PessoaDAO dao = new PessoaDAO();
                    pessoa.Tipo = 0;
                    dao.Adiciona(pessoa);
                    return RedirectToAction("Index");
                }
                else
                {
                ViewBag.Pessoa = pessoa;
                return View("Cadastro");
                }
            
        }     
       
    }
}
