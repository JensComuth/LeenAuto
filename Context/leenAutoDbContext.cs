using Microsoft.EntityFrameworkCore;
using testLeenAUto.Entities;

namespace testLeenAUto.Context
{
    public class leenAutoDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public leenAutoDbContext(DbContextOptions<leenAutoDbContext> options) : base(options)
        {
            
        }

    }
}
