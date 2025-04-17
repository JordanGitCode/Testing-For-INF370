using Microsoft.EntityFrameworkCore;

namespace TEST_API_CodeFirst.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<Title> Titles => Set<Title>();
        public DbSet<Race> Races => Set<Race>();
        public DbSet<Gender> Genders => Set<Gender>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.Role_ID);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Title)
                .WithMany()
                .HasForeignKey(u => u.Title_ID);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Race)
                .WithMany()
                .HasForeignKey(u => u.Race_ID);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Gender)
                .WithMany()
                .HasForeignKey(u => u.Gender_ID);
        }

    }
}
