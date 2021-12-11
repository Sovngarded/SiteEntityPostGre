using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SiteDomain
{
    public interface ILeadService
    {
        Task<Guid> Create(LeadModel lead);
        Task<LeadModel> Get(Guid id);
        Task Update(LeadModel lead);
        Task Delete(Guid leadId);
    }
}
