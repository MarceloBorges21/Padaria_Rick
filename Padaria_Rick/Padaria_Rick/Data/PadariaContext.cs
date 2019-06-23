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
		public DbSet<Promocao> Promocao { get; set; }
		public DbSet<Venda> Venda { get; set; }
		public DbSet<Produto_FK_Venda> Produto_has_Venda { get; set; }
		public DbSet<Promocao_FK_Produto> Promocao_has_Produto { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

			modelBuilder
			   .Entity<Produto_FK_Venda>()
			   .HasKey(pp => new { pp.ProdutoId,pp.VendaId });

			modelBuilder
			   .Entity<Promocao_FK_Produto>()
			   .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });

			base.OnModelCreating(modelBuilder);
		}
	}
}