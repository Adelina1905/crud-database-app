using Microsoft.EntityFrameworkCore;
using BlazorWebAppMovies1.Models;

namespace BlazorWebAppMovies1.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options) { }

        public DbSet<Movie> Movies { get; set; } = default!;
    }
}