using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.Entity
{
	public class Venda
	{
		public int Id { get; set; }
		public DateTime Data { get; set; }
		public int Mesa { get; set; }
		public char Status { get; set; }
		public float Valor_Total { get; set; }
		public string Forma_Pagamento { get; set; }		
		public int PessoaId{ get; set; }
		public Pessoa Pessoa { get; set; }
	}
}