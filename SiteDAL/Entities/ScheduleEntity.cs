
using SiteDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SiteDAL
{
    public class ScheduleEntity : BaseEntity
    {
        public int ScheduleId { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleWhen { get; set; }
        public string ScheduleWhy { get; set; }
    }
}
