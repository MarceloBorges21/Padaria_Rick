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
        public void Adiciona(Pessoa pessoa)
        {
            using (var context = new PadariaContext())
            {
                context.Pessoa.Add(pessoa);
                context.SaveChanges();
            }
        }

        public IList<Pessoa> Lista()
        {
            using (var context = new PadariaContext())
            {
                return context.Pessoa.ToList();
            }
        }

        public void Atualiza(Pessoa pessoa)
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