using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dtos.Facility.Request;
using FastCare.Domain.Models;
using FastCare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace FastCare.Infrastructure.Repositories
{
    public class FacilityRepository : IFacilityRepository
    {
        private readonly FastCareDbContext _context;
        private readonly IMapper _mapper;

        public FacilityRepository(FastCareDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Facility> CreateFacility(CreateFacilityDto dto)
        {
            var facility = _mapper.Map<Facility>(dto);
            await _context.Facilities.AddAsync(facility);
            await _context.SaveChangesAsync();
            return facility;
        }

        public async Task<Facility> GetFacilityById(Guid FacilityId)
        {
            return await _context.Facilities.FindAsync(FacilityId);
        }

        public async Task<bool> DeleteFacility(Guid FacilityId)
        {
            var facility=await GetFacilityById(FacilityId);
            if(facility==null){
                return false;
            }
            _context.Facilities.Remove(facility);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Facility>> GetAllFacilities()
        {
            return await _context.Facilities.ToListAsync();
        }

        public async Task<Facility> UpdateFacility(Guid FacilityId, UpdateFacilityDto dto)
        {
            var facility=await GetFacilityById(FacilityId);
            if(facility==null){
                return null;
            }
            facility.BookingPrice=dto.BookingPrice;
            facility.FacilityType=dto.FacilityType;
            facility.Ratings=dto.Ratings;
            facility.BookingPrice=dto.BookingPrice;
            facility.Location=dto.Location;
            facility.Availability=dto.Availability;
            facility.UpdatedAt=DateTime.Now;
            await _context.SaveChangesAsync();
            return facility;
        }
    }
}
