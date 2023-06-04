using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Word> Words { get; set; }
        public DbSet<Translate> Translates { get; set; }
        public DbSet<WordList> WordLists { get; set; }

        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Word>()
                .HasOne(w => w.Progress)
                .WithOne(p => p.Word)
                .HasForeignKey<Progress>(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
