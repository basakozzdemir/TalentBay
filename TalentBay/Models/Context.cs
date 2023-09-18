using Microsoft.EntityFrameworkCore;

namespace TalentBay.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        // DbSet'ler ve diğer tablolar burada tanımlanır.
    }
}
