using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DAL
{
    public class AnimeContext : DbContext
    {
        public AnimeContext(DbContextOptions<AnimeContext> options) : base(options)
        {
        }

        public DbSet<Anime> Anime { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");

            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocaldb;Initial Catalog=AnimeApi;Trusted_Connection=True;MultipleActiveResultSets=true");
        }   
    }
}
