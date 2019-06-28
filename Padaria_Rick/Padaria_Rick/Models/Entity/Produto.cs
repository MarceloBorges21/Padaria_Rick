using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.Entity
{
	public class Produto
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public int CategoriaId { get; set; }
		public Categoria Categoria { get; set; }
		public float Valor { get; set; }
		public int PessoaId { get; set; }
		public Pessoa Pessoa { get; set; }
	}
}