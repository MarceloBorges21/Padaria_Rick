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
            IList<Pessoa> pessoa = dao.Lista();

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
				var pessoa = dao.BuscaPorId(Convert.ToInt32(Id));

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
					pessoa.Tipo = 0;
					dao.Atualiza(pessoa);
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
                    //pessoa.Cifrar(pessoa.Senha);
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
}
