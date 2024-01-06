using Microsoft.EntityFrameworkCore;
using NguyenVanHuan782.Models;

namespace NguyenVanHuan782.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Student> Student { get; set;}
        public DbSet<Doituong2> Doituong2 {get; set;}
    }
}