using Padaria_Rick.Data;
using Padaria_Rick.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.DAO
{
    public class PessoaDAO 
    {
        public void Adicionar(Pessoa pessoa)
        {
            using (var context = new PadariaContext())
            {
                context.Pessoa.Add(pessoa);
                context.SaveChanges();
            }
        }

        public IList<Pessoa> Listar()
        {
            using (var context = new PadariaContext())
            {
                return context.Pessoa.ToList();
            }
        }

        public Pessoa BuscarPorId(int id)
        {
            using (var contexto = new PadariaContext())
            {
                return contexto.Pessoa.Find(id);
            }
        }

        public void Atualizar(Pessoa pessoa)
        {
            using (var context = new PadariaContext())
            {
                context.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Remover(Pessoa pessoa)
        {
            using (var context = new PadariaContext())
            {
                context.Pessoa.Remove(pessoa);
                context.SaveChanges();
            }
        }
    }
}