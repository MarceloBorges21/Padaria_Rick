using System.Data.Entity.ModelConfiguration.Conventions;
using Padaria_Rick.Models.Entity;
using System.Data.Entity;

namespace Padaria_Rick.Data
{
	public class PadariaContext : DbContext
	{
		public PadariaContext():
			base("BancoPadaria") {}

		public DbSet<Pessoa> Pessoa { get; set; }
		public DbSet<Categoria> Categoria { get; set; }
		public DbSet<Produto> Produto { get; set; }
		public DbSet<Promocao> Promocoe  { get; set; }
		public DbSet<Venda> Venda { get; set; }
		public DbSet<Produto_Venda> Produto_Venda { get; set; }
		public DbSet<Promocao_Produto> Promocao_Produto { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{			
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

			modelBuilder
			   .Entity<Produto_Venda>()
			   .HasKey(pp => new { pp.ProdutoId,pp.VendaId });

			modelBuilder
			   .Entity<Promocao_Produto>()
			   .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });

			base.OnModelCreating(modelBuilder);
		}       
    }
}