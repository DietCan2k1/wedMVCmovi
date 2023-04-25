using Microsoft.EntityFrameworkCore;
using MoviWed.Models;

namespace MoviWed.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
  

        public DbSet<CategoryModels> category { get; set; }

        public DbSet<Users> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var sqlConnection = "Server=localhost;Port=3306;Database=dv_movi;Uid=root;Pwd=;MaximumPoolSize=500;";
                optionsBuilder.UseMySql(sqlConnection,
                   MySqlServerVersion.LatestSupportedServerVersion);
            }
        }

    }
}
