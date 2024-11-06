using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Server.Models.User> User { get; set; } = default!;
    }
}
