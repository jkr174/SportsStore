using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
namespace SportsStore.Models
{
    public class PageIngo : DbContext
    {
        public PageIngo(DbContextOptions<PageIngo> options)
        : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}