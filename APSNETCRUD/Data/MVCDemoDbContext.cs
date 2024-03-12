using APSNETCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace APSNETCRUD.Data
{
    public class MVCDemoDbContext : DbContext
    {
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet <Employee> Employees { get; set; }
    }
}
