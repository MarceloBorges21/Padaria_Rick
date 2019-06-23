using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Padaria_Rick.Models.Entity
{
	public class Promocao_FK_Produto
	{
		public int ProdutoId { get; set; }
		public Produto Produto { get; set; }
		public int PromocaoId { get; set; }
		public Promocao Promocao { get; set; }
		public int Quantidade { get; set; }
	}
}