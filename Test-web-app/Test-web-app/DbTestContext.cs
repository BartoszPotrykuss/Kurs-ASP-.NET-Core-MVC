using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Test_web_app.Models;

namespace Test_web_app
{
    public class DbTestContext : IdentityDbContext<UserModel>
    {
        public DbTestContext(DbContextOptions<DbTestContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
