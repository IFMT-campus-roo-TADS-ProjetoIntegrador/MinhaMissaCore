using Microsoft.EntityFrameworkCore;
using MinhaMissaCore.Model;

namespace MinhaMissaCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
        public DbSet<Event> Events { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
