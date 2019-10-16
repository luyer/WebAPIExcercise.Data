using Microsoft.EntityFrameworkCore;
using WebAPIExercise.Data.Models;

namespace WebAPIExercise.Data
{

    public class WebAPIExerciseContext : DbContext
    {
        public WebAPIExerciseContext(DbContextOptions<WebAPIExerciseContext> options) : base(options) {}

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }


}