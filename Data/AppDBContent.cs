using Microsoft.EntityFrameworkCore;
using WebProject.Data.Models;

namespace WebProject.Data
{
    public class AppDBContent : DbContext
    {
        #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
