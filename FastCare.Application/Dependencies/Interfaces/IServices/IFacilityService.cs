using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dtos.Facility.Request;
using FastCare.Application.Dtos.Facility.Response;

namespace FastCare.Application.Dependencies.Interfaces.IServices
{
    public interface IFacilityService
    {
        Task<ReadFacilityDto> CreateFacility(CreateFacilityDto dto);
        Task<IEnumerable<ReadFacilityDto>> GetAllFacilities();
        Task<ReadFacilityDto> GetFacilityById(Guid FacilityId);
        Task<ReadFacilityDto> UpdateFacility(Guid FacilityId, UpdateFacilityDto dto);
        Task<bool> DeleteFacility(Guid FacilityId);
    }
}
