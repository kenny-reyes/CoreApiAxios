using api.Domain;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>()
                .HasData(new Character
                {
                    gender = "male",
                    id = 1,
                    image = "https://rickandmortyapi.…/character/avatar/1.jpeg",
                    name = "Rick",
                    species = "human"});
        }
    }
}
