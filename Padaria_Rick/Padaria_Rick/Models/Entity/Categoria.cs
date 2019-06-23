using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.Entity
{
	public class Categoria
	{
		public int Id { get; set; }
		public int Descricao { get; set; }
		public Pessoa Pessoa { get; set; }
		public int PessoaId { get; set; }
	}
}