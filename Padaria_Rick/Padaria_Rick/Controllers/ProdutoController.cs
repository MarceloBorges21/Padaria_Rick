using Padaria_Rick.Models.DAO;
using Padaria_Rick.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Padaria_Rick.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto
        public ActionResult Index()
        {
            ProdutoDAO dao = new ProdutoDAO();           
            IList<Produto> produto = dao.Lista();

            return View(produto);
        }
  
        // GET: Produto/Create
        public ActionResult Cadastro()
        {
            ViewBag.Produto = new Produto();
            CategoriaDAO dao = new CategoriaDAO();
            IList<Categoria> categoria = dao.Lista();
            ViewBag.Categoria = categoria;
            ViewBag.Produto = new Produto();
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Adicionar(Produto produto)
        {
            if (ModelState.IsValid)
            {
                ProdutoDAO dao = new ProdutoDAO();
                produto.PessoaId = 1;

                dao.Adiciona(produto);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Produto = produto;
                CategoriaDAO categoriaDAO = new CategoriaDAO();
                ViewBag.Categoria = categoriaDAO.Lista();
                return View("Cadastro");
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Produto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
