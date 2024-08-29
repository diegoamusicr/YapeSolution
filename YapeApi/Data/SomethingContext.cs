using Microsoft.EntityFrameworkCore;
using YapeApi.Model;

namespace YapeApi.Data
{
    public class SomethingContext(DbContextOptions<SomethingContext> options) : DbContext(options)
    {

        public DbSet<Something> Somethings { get; set; }
    }
}