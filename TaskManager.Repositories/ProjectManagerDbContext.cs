using TaskManager.Entities;
using System.Data.Entity;

namespace TaskManager.Repositories
{
    public class ProjectManagerDbContext : DbContext
    {
        public ProjectManagerDbContext():base("name=ProjectManagerDb")
        {
        }

        public DbSet<ParentTask> ParentTasks { get; set; }
        public DbSet<ProjectTask> Tasks { get; set; }

    }
}
