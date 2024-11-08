using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<User> User { get; set; } = default!;
        public DbSet<UserScoreData> UserScoreData { get; set; } = default!;
        public DbSet<Games> Games { get; set; } = default!;
    }
}
