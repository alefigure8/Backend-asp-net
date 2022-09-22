using Microsoft.EntityFrameworkCore;
using backendTest.Models.DataModels;

namespace backendTest.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) 
        {
        
        }
        
        //TODO: Add DbSets
        public DbSet<User>? Users { get; set; }
    }

}
