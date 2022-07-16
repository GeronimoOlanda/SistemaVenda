using Microsoft.EntityFrameworkCore;
using SistemaVendas.Entidades;

namespace SistemaVendas.DAL
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public DbSet<VendaProdutos> VendaProdutos { get; set; }

        //setando a classe construtora obrigatoria, onde estamos pssando a nossa classe dalm e setano o dbContext dela
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //especificando o tipo da nossa entidade

        //override vamos sobrescrever o nosso metodo
        protected override void OnModelCreating(ModelBuilder builder)
        {   
            //estamos dizendo que vamos sobreescrever
            base.OnModelCreating(builder);

            //dizendo que o codigoVenda e CodigoProduto são PrimaryKey
            builder.Entity<VendaProdutos>().HasKey(x => new { x.CodigoVenda, x.CodigoProduto });
            builder.Entity<VendaProdutos>()
                .HasOne(x => x.Venda)   //hasOne diz que possui um alguma coisa, no nosso caso, uma venda
                .WithMany(y => y.Produtos) //withMany diz que em uma venda, poderemos ter muitos produtos vendidos
                .HasForeignKey(x => x.CodigoVenda);

            builder.Entity<VendaProdutos>()
             .HasOne(x => x.Produto)   //hasOne diz que possui um alguma coisa, no nosso caso, uma venda
             .WithMany(x => x.Vendas) //withMany diz que em uma venda, poderemos ter muitos produtos vendidos
             .HasForeignKey(x => x.CodigoProduto);
        }
    }
}
