using Padaria_Rick.Data;
using Padaria_Rick.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.DAO
{
    public class ProdutoDAO
    {
        public void Adicionar(Produto produto)
        {
            using (var context = new PadariaContext())
            {
                context.Produto.Add(produto);
                context.SaveChanges();
            }
        }

        public IList<Produto> Listar()
        {
            using (var context = new PadariaContext())
            {
                var produtos = context.Produto.ToList();
                return produtos;
            }
        }

        public IList<Produto> ListarBebida()
        {
            using (var context = new PadariaContext())
            {
                var produtos = context.Produto.Where( x=> x.CategoriaId == 1).ToList();
                return produtos;
            }        
        }

        public IList<Produto> ListarSalgado()
        {
            using (var context = new PadariaContext())
            {
                var produtos = context.Produto.Where(x => x.CategoriaId == 3).ToList();
                return produtos;
            }
        }

        public IList<Produto> ListarDoce()
        {
            using (var context = new PadariaContext())
            {
                var produtos = context.Produto.Where(x => x.CategoriaId == 5).ToList();
                return produtos;
            }
        }

        public Produto BuscarPorId(int id)
        {
            using (var contexto = new PadariaContext())
            {
                return contexto.Produto.Include("Categoria")
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
            }
        }

        public void Atualizar(Produto produto)
        {
            using (var contexto = new PadariaContext())
            {
                contexto.Entry(produto).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Remover(Produto produto)
        {
            using (var context = new PadariaContext())
            {
                context.Produto.Remove(produto);
                context.SaveChanges();
            }
        }

    }
}