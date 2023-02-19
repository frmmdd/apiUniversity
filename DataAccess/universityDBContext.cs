using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.Models.DataModels;

namespace UniversityApiBackend.DataAccess
{
    public class universityDBContext : DbContext
    {
        public universityDBContext(DbContextOptions<universityDBContext> options): base(options)
        {

        }

        public DbSet<User>? users { get; set; }
        public DbSet<Course>? courses { get; set; }
    }
}
