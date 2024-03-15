using Microsoft.EntityFrameworkCore;
using WebApplication10.Model;

namespace WebApplication10.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Slider> Sliders { get; set; }


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>(entity =>
            {
                entity.Property(p => p.Title).IsRequired().HasMaxLength(200);

                entity.Property(p => p.Slogan).IsRequired().HasMaxLength(500);
               
                entity.Property(p => p.BackgroundImageUrl).IsRequired().HasMaxLength(1000);
            });

        }
    }
}
