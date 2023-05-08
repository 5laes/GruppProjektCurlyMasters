using System.ComponentModel.DataAnnotations;

namespace DbLibrary
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public ICollection<TimeReport> TimeReports { get; set; }
    }
}