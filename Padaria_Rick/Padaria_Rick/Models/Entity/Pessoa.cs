using Padaria_Rick.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.Entity
{
	public class Pessoa 
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string Endereco { get; set; }
		public int Tipo { get; set; }
		public string Login { get; set; }
		public string Senha { get; set; }
	}
	
}