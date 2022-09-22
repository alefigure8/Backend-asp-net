using Microsoft.EntityFrameworkCore;
using backendTest.Models.DataModels;

namespace backendTest.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) 
        {
        
        }
        
        public DbSet<User>? Users { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Curso>? Courses { get; set; }
        public DbSet<Chapters>? Chapters { get; set; }
        public DbSet<Student>? Students { get; set; }
    }

}
