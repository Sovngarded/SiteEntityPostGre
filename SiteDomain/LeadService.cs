using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SiteDAL;
using SiteDAL.Entities;
using SiteDAL.Repositories;
using System;
using System.Threading.Tasks;


namespace SiteDomain
{
    public class LeadService : ILeadService
    {
        private readonly IDbRepository _dbRepository;
        private readonly IMapper _mapper;
        private readonly ScheduleEntity _currentSchedule;

        public LeadService(IDbRepository dbRepository, IMapper mapper, ScheduleEntity currentSchedule)
        {
            _dbRepository = dbRepository;
            _mapper = mapper;
            _currentSchedule = currentSchedule;
        }

        public async Task<Guid> Create(LeadModel lead)
        {
            var entity = _mapper.Map<LeadEntity>(lead);
            entity.ScheduleItemCreated = _currentSchedule.Id;

            var result = await _dbRepository.Add(entity);
            await _dbRepository.SaveChangesAsync();

            return result;
        }

        public async Task<LeadModel> Get(Guid id)
        {
            var lead = await _dbRepository.Get<LeadEntity>().FirstOrDefaultAsync(x => x.Id == id);
            var leadModel = _mapper.Map<LeadModel>(lead);
            var schedule = _dbRepository.Add(new ScheduleEntity());
            await _dbRepository.SaveChangesAsync();
            return leadModel;
        }

        public async Task Update(LeadModel lead)
        {
            var entity = _mapper.Map<LeadEntity>(lead);

            await _dbRepository.Update(entity);
            await _dbRepository.SaveChangesAsync();
        }

        public async Task Delete(Guid leadId)
        {
            await _dbRepository.Delete<LeadEntity>(leadId);
            await _dbRepository.SaveChangesAsync();
        }
    }
}

