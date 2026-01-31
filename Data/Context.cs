using Examination_System.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Examination_System.Data
{
    public class Context : DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data source =DESKTOP-LPP34FA;initial catalog=ExaminationSystem; integrated security = true ; trust server certificate = true ").LogTo(log=>Debug.WriteLine(log),LogLevel.Information);
        }
    }
}
