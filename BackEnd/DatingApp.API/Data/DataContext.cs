using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        private DbSet<Value> values;

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get => values; set => values = value; }

    }
}