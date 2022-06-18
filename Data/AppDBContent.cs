using Microsoft.EntityFrameworkCore;
using WebProject.Data.Models;

namespace WebProject.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
