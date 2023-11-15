using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Facility.Request;
using FastCare.Application.Dtos.Facility.Response;

namespace FastCare.Application.Dependencies.Services
{
    public class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _repo;
        private readonly IMapper _mapper;
        public FacilityService(IFacilityRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
            
        }
        public async Task<ReadFacilityDto> CreateFacility(CreateFacilityDto dto)
        {
           var facility=await _repo.CreateFacility(dto);
           if(facility==null){
            return null;
           }
           var facilityDto=_mapper.Map<ReadFacilityDto>(facility);
           return facilityDto;
        }

        public async Task<bool> DeleteFacility(Guid FacilityId)
        {
            return await _repo.DeleteFacility(FacilityId);
        }

        public async Task<IEnumerable<ReadFacilityDto>> GetAllFacilities()
        {
            var facilities=await _repo.GetAllFacilities();
            if(facilities==null||facilities.Count()==0){
                return null;
            }
            var facilitiesDto=facilities.Select(x=>_mapper.Map<ReadFacilityDto>(x)).ToList();
            return facilitiesDto;
        }

        public async Task<ReadFacilityDto> GetFacilityById(Guid FacilityId)
        {
            var facility=await _repo.GetFacilityById(FacilityId);
            if(facility==null){
                return null;
            }
            var facilityDto=_mapper.Map<ReadFacilityDto>(facility);
            return facilityDto;
        }

        public async Task<ReadFacilityDto> UpdateFacility(Guid FacilityId, UpdateFacilityDto dto)
        {
             var facility=await _repo.UpdateFacility(FacilityId,dto);
            if(facility==null){
                return null;
            }
            var facilityDto=_mapper.Map<ReadFacilityDto>(facility);
            return facilityDto;
        }
    }
}