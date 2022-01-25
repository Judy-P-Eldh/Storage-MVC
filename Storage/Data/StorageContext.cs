#nullable disable
using Microsoft.EntityFrameworkCore;

namespace Storage.Data
{
    public class StorageContext : DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options)
            : base(options)
        {
        }

        public DbSet<Storage.Models.Product> Product { get; set; }

    }
}
