using System;
using System.Collections.Generic;
using System.Text;

namespace SiteDAL.Entities
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public Guid? ScheduleItemCreated { get; set; }
        public Guid? ScheduleItemUpdated { get; set; }
    }
}
