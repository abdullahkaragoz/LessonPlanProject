using LessonPlan.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace LessonPlan.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ClassRoom> ClassRooms{ get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<LessonTime> LessonTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


           base.OnModelCreating(modelBuilder);
        }
    }
}
