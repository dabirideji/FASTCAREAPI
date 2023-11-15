using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dtos.Facility.Request;
using FastCare.Domain.Models;

namespace FastCare.Application.Dependencies.Interfaces.IRepositories
{
    public interface IFacilityRepository
    {
        Task<Facility> CreateFacility(CreateFacilityDto dto);
        Task<IEnumerable<Facility>> GetAllFacilities();
        Task<Facility> GetFacilityById(Guid FacilityId);
        Task<Facility> UpdateFacility(Guid FacilityId,UpdateFacilityDto dto);
        Task<bool> DeleteFacility(Guid FacilityId);
    }
}