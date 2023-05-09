using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DbLibrary
{
    [Serializable]
    public class TimeReport
    {
        [Key]
        public int Id { get; set; }
        public DateTime TimeCheckIn { get; set; }
        public DateTime TimeCheckOut { get; set; }
        public int EmployeeId { get; set; }
        [JsonIgnore]
        public Employee? Employee { get; set; }
    }
}
