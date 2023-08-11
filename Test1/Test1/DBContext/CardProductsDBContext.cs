using Microsoft.EntityFrameworkCore;

namespace Test1.DBContext
{
    public class CardProductsDBContext : DbContext
    {
        public DbSet<CardProducts> CardContent { get; set; }

        public CardProductsDBContext(DbContextOptions<CardProductsDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CardProducts>().HasNoKey();
        }
    }
}
