using Microsoft.EntityFrameworkCore;

namespace PROG73020_EAD_Group1.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project_Account>().HasKey(projectAccount => new
            {
                projectAccount.ProjectId,
                projectAccount.AccountId
            });

            // defines the relationships on the C# side
            modelBuilder.Entity<Project_Account>().HasOne(project => project.Project).WithMany(projectAccount => projectAccount.Projects_Accounts).HasForeignKey(project => project.ProjectId);
            modelBuilder.Entity<Project_Account>().HasOne(account => account.Account).WithMany(projectAccount => projectAccount.Projects_Accounts).HasForeignKey(project => project.AccountId);

            base.OnModelCreating(modelBuilder);
        }

        // defines table names too
        public DbSet<Project> Projects { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Project_Account> Projects_Accounts { get; set; }


    }
}
