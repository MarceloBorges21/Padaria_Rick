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
		PessoaDAO dao = new PessoaDAO();
		// GET: Pessoa
		public ActionResult Index()
        {  
            IList<Pessoa> pessoa = dao.Listar();

			ViewBag.ListaPessoa = pessoa;

            return View();
        }

        public ActionResult Cadastro(Pessoa pessoa)
        {
            return View();          
        }


        // POST: Pessoa/Create
        [HttpPost]       
        public ActionResult AdicionaCliente(Pessoa pessoa)
        {				 
                if (ModelState.IsValid)
                {
                    pessoa.Tipo = TipoPessoa.Cliente;
                    dao.Adicionar(pessoa);
                    return RedirectToAction("Index");
                }
                else
                {
                ViewBag.Pessoa = pessoa;
                return View("Cadastro");
                }			
		}

        [HttpPost]
        public JsonResult Salvar(Pessoa pessoa)
        {
            dao.Adicionar(pessoa);
            return Json("Dados salvos com sucesso");
        }
   
        [HttpPost]
        public JsonResult Editar(Pessoa pessoa)
        {         
                dao.Atualizar(pessoa);
                return Json("Dados salvos com sucesso.");                  
        }

        public JsonResult CarregaDados(int Id)
        {          
            var lista = dao.BuscarPorId(Id);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Excluir(int id)
        {      
            string validacao = (dao.Excluir(id) ? "Sim" : "Não");
       
            return Json(validacao);  
        }
    }
}
