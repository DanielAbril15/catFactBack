using Microsoft.EntityFrameworkCore;

namespace BackendGodoy.Models
{
    public class CatFactsContext:DbContext
    {
        public CatFactsContext(DbContextOptions<CatFactsContext> options):base (options) {}

        public DbSet<History> Histories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<History>(history => 
            {
                history.HasKey(h => h.Id);
                history.Property(h=>h.date).IsRequired();
                history.Property(h => h.words).IsRequired();
                history.Property(h => h.cat_fact).IsRequired();
                history.Property(h => h.gif_url).IsRequired();
            });
        }
    }
}
