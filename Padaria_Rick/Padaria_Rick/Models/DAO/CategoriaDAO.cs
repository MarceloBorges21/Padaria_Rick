using Padaria_Rick.Data;
using Padaria_Rick.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.DAO
{
    public class CategoriaDAO
    {
        public void Adiciona(Categoria categoria)
        {
            using (var context = new PadariaContext())
            {
                context.Categoria.Add(categoria);
                context.SaveChanges();
            }
        }

        public IList<Categoria> Lista()
        {
            using (var context = new PadariaContext())
            {
                return context.Categoria.ToList();
            }
        }

        public Categoria BuscaPorId(int id)
        {
            using (var contexto = new PadariaContext())
            {
                return contexto.Categoria.Find(id);
            }
        }

        public void Atualiza(Categoria categoria)
        {
            using (var context = new PadariaContext())
            {
                context.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Remover(Categoria categoria)
        {
            using (var context = new PadariaContext())
            {
                context.Categoria.Remove(categoria);
                context.SaveChanges();
            }
        }
    }
}