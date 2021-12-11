using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleWhen { get; set; }
        public string ScheduleWhy { get; set; }
    }
}
