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

        // GET: Pessoa/Create
        [Route("CadastroCliente")]
        public ActionResult Cadastro(int Id = 0)
        {			
            ViewBag.Pessoa = new Pessoa();
			
			if (Id == 0)
			{
				Id = 0;
				ViewBag.Id = Id;
				ViewBag.Nome = "";
				ViewBag.CPF = "";
				ViewBag.Endereco = "";
				ViewBag.Login = "";
				ViewBag.Senha = "";
			}
			else
			{
				var pessoa = dao.BuscarPorId(Convert.ToInt32(Id));

				ViewBag.Pessoa.Id = Id;
				ViewBag.ListaPessoa = pessoa;
				
				ViewBag.Nome = pessoa.Nome;
				ViewBag.CPF = pessoa.CPF;
				ViewBag.Endereco = pessoa.Endereco;
				ViewBag.Login = pessoa.Login;
				ViewBag.Senha = pessoa.Senha;				
			}
            return View();
        }

        // POST: Pessoa/Create
        [HttpPost]       
        public ActionResult AdicionaCliente(Pessoa pessoa)
        {
			if (pessoa.Id > 0)
			{
				if (ModelState.IsValid)
				{
					pessoa.Tipo = TipoPessoa.Cliente;
					dao.Atualizar(pessoa);
					return RedirectToAction("Index");
				}
				else
				{
					ViewBag.Pessoa = pessoa;
					return View("Cadastro");
				}
			}
			else
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
		}     
       
    }
}
