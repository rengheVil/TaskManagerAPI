using Microsoft.EntityFrameworkCore;
using System.Net;
using TaskManagerAPIa.Model;

namespace TaskManagerAPIa.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<UserLogin> UsersLogins { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                 .HasOne(a => a.Address)
                 .WithOne(b => b.User)
                 .HasForeignKey<Address>(c => c.UserId);

            modelBuilder.Entity<User>()
                .HasMany(o => o.Tasks)
                .WithOne(p => p.Assignee)
                .HasForeignKey(o => o.AssigneeId);

            modelBuilder.Entity<TaskItem>()
                .HasMany(a => a.Checklist)
                .WithOne(u => u.Task)
                .HasForeignKey(u => u.TaskId);


            

            base.OnModelCreating(modelBuilder);
        }

    }
}
