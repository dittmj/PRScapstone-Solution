using Microsoft.EntityFrameworkCore;

namespace PRScapstone.Models
{
    public class PRSDbContext : DbContext 
    {
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Vendor> Vendors { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<RequestLine> RequestLines { get; set; } = null!;
        public PRSDbContext() { }
        public PRSDbContext(DbContextOptions<PRSDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;" + "database=PRScapstone;" +
                          "trusted_connection=true;" + "trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
