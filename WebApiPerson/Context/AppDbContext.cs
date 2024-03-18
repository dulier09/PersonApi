using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(p => p.CreationDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Person>()
                .Property(p => p.UpdateDate)
                .HasDefaultValueSql("GETDATE()");
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Person>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreationDate = DateTime.Now;
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                }
            }
            return base.SaveChanges();
        }
        public DbSet<Person> Persons { get; set; }
    }
}
