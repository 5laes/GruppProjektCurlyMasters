using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary
{
    public class TimeReport
    {
        [Key]
        public int Id { get; set; }
        public DateTime TimeCheckIn { get; set; }
        public DateTime TimeCheckOut { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
