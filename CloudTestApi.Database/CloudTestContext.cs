using CloudTestApi.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace CloudTestApi.Database
{
    public class CloudTestContext : DbContext
    {
        public CloudTestContext(DbContextOptions<CloudTestContext> context) : base(context)
        {

        }

        public DbSet<Cities> Cities { get; set; }
    }
}