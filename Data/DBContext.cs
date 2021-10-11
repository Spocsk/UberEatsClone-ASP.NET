using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using UberEatsClone.Models;

namespace UberEatsClone.Data
{
    public class DBContext: DbContext
    {
        public DbSet<Meal> Meals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=UberEatsClone;Uid=dylan;Pwd=password;");

            optionsBuilder.UseMySql(connection, ServerVersion.AutoDetect(connection));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meal>(p =>
            {
                p.HasKey(o => o.Id);
                p.Property(o => o.Name);
                p.Property(o => o.Country);
                p.Property(o => o.Price);
            });
        }
    }
}