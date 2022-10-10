using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions options) : base(options) { }

        // TODO: Add Sets (tables of Databases)
        public DbSet<User>? Users { get; set; }
        public DbSet<Curso> Cursos { get; set; }
    }
}
