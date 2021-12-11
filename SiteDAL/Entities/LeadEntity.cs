using System;
using System.Collections.Generic;
using System.Text;

namespace SiteDAL.Entities
{
    public class LeadEntity : BaseEntity
    {

        public Guid PersonId { get; set; }
        public ScheduleEntity Schedule { get; set; }
    }
}
