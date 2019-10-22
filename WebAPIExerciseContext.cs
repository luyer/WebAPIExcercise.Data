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

        /* 
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<CustomerAddress>()
            .HasKey(ca => new {ca.CustomerId, ca.AddressId});
            builder.Entity<CustomerAddress>()
            .HasOne(ca=> ca.Customer).WithMany(ca=>ca.CustomerAddresses)
            .HasForeignKey(ca=> ca.CustomerId);
            builder.Entity<CustomerAddress>()
            .HasOne(ca=>ca.Address).WithMany(ca=>ca.CustomerAddresses)
            .HasForeignKey(ca=> ca.AddressId);
        }
        */




    }


}