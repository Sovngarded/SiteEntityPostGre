using System;
using System.Collections.Generic;
using System.Text;

namespace SiteDAL.Entities
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool IsActive { get; set; }

    }
}
