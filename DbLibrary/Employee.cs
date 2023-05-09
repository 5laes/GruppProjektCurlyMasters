using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DbLibrary
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ProjectId { get; set; }
        [JsonIgnore]
        public Project? Project { get; set; }
        [JsonIgnore]
        public ICollection<TimeReport>? TimeReports { get; set; }
    }
}