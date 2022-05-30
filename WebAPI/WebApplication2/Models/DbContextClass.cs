using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }
        public DbSet<PensionerModel> Pensioner { get; set; }
    }
}
