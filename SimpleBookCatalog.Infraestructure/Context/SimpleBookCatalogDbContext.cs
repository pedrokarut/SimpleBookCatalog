using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Entities;

namespace SimpleBookCatalog.Infraestructure.Context
{
    public class SimpleBookCatalogDbContext : DbContext
    {
        public SimpleBookCatalogDbContext(DbContextOptions<SimpleBookCatalogDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

    }
}
