using DbLibrary;
using Microsoft.EntityFrameworkCore;

namespace GruppProjektCurlyMasters.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeReport> timeReports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    Id = 1,
                    Name = "ColdFire"
                });
            modelBuilder.Entity<Project>().
                HasData(new Project
                {
                    Id = 2,
                    Name = "HotIce"
                });

            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    Id = 1,
                    Name = "Claes",
                    Age = 25,
                    ProjectId = 1
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    Id = 2,
                    Name = "Alfred",
                    Age = 26,
                    ProjectId = 2
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    Id = 3,
                    Name = "Dennis",
                    Age = 24,
                    ProjectId = 2
                });
            modelBuilder.Entity<Employee>().
                HasData(new Employee
                {
                    Id = 4,
                    Name = "Tomten",
                    Age = 99,
                    ProjectId = 1
                });

            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 1,
                    TimeCheckIn = new DateTime(2023, 02, 01, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 01, 16, 0, 0),
                    EmployeeId = 1
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 2,
                    TimeCheckIn = new DateTime(2023, 02, 02, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 02, 16, 0, 0),
                    EmployeeId = 1
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 3,
                    TimeCheckIn = new DateTime(2023, 02, 03, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 03, 16, 0, 0),
                    EmployeeId = 1
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 4,
                    TimeCheckIn = new DateTime(2023, 02, 01, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 01, 16, 0, 0),
                    EmployeeId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 5,
                    TimeCheckIn = new DateTime(2023, 02, 02, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 02, 16, 0, 0),
                    EmployeeId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 6,
                    TimeCheckIn = new DateTime(2023, 02, 03, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 03, 16, 0, 0),
                    EmployeeId = 2
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 7,
                    TimeCheckIn = new DateTime(2023, 02, 01, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 01, 16, 0, 0),
                    EmployeeId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 8,
                    TimeCheckIn = new DateTime(2023, 02, 02, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 02, 16, 0, 0),
                    EmployeeId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 9,
                    TimeCheckIn = new DateTime(2023, 02, 03, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 03, 16, 0, 0),
                    EmployeeId = 3
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 10,
                    TimeCheckIn = new DateTime(2023, 02, 01, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 01, 16, 0, 0),
                    EmployeeId = 4
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 11,
                    TimeCheckIn = new DateTime(2023, 02, 02, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 02, 16, 0, 0),
                    EmployeeId = 4
                });
            modelBuilder.Entity<TimeReport>().
                HasData(new TimeReport
                {
                    Id = 12,
                    TimeCheckIn = new DateTime(2023, 02, 03, 7, 0, 0),
                    TimeCheckOut = new DateTime(2023, 02, 03, 16, 0, 0),
                    EmployeeId = 4
                });
        }
    }
}
