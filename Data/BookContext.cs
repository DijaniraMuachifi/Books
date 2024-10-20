using ECommerceApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } // Exemplo de uma entidade
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configura a propriedade PublishedDate para garantir que seja sempre UTC
            modelBuilder
                .Entity<Book>()
                .Property(b => b.PublishedDate)
                .HasConversion(
                    v => v, // Valor que será salvo no banco de dados
                    v => DateTime.SpecifyKind(v, DateTimeKind.Utc) // Converte para UTC ao ler do banco de dados
                );
        }
    }
}
