using System.Data;
using System.Data.Common;
using learn.Models;
using Microsoft.EntityFrameworkCore ; 
namespace learn.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
