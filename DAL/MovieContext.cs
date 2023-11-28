using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; } = default!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // var connectionString = Environment.GetEnvironmentVariable("DefaultConnection");

            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocaldb;Initial Catalog=MoviesApi;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
