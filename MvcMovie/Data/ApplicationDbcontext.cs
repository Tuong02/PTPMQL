using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using MvcMovie.Models;

    
namespace MvcMovie.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Person> Person { get; set; }
        public DbSet<MvcMovie.Models.Employee> Employee { get; set; } = default!;
        public DbSet<MvcMovie.Models.Student> Student { get; set; } = default!;
    }
}
//NguyenHuyTuong2021050718