using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.Entity
{
	public class Produto_FK_Venda
	{
		public int ProdutoId { get; set; }
		public Produto Produto { get; set; }
		public int VendaId { get; set; }
		public Venda Venda { get; set; }
	}
}