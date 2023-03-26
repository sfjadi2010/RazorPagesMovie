using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Data
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                ReleaseDate = DateTime.Parse("1994-10-14"),
                Genre = "Drama",
                Price = (decimal) 9.99
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 2,
                Title = "The Godfather",
                ReleaseDate = DateTime.Parse("1972-3-24"),
                Genre = "Crime",
                Price = (decimal) 14.99
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 3,
                Title = "The Godfather: Part II",
                ReleaseDate = DateTime.Parse("1974-12-20"),
                Genre = "Crime",
                Price = (decimal) 9.99
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 4,
                Title = "Forrest Gump",
                ReleaseDate = DateTime.Parse("1994-07-06"),
                Genre = "Drama",
                Price = (decimal)8.99
            });

            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 5,
                Title = "The Dark Knight",
                ReleaseDate = DateTime.Parse("2008-07-18"),
                Genre = "Action",
                Price = (decimal)8.99
            });

        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
