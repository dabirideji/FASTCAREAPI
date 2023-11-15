using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Infrastructure.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace FastCare.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly FastCareDbContext _context;
        private readonly IMapper _mapper;

        public DoctorRepository(FastCareDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Doctor> CreateDoctor(CreateDoctorDto dto)
        {
            var doctor = _mapper.Map<Doctor>(dto);
            await _context.Doctors.AddAsync(doctor);
            await _context.SaveChangesAsync();
            return doctor;
        }

        public async Task<Doctor> GetDoctorById(Guid DoctorId)
        {
            var doctor=await _context.Doctors.FindAsync(DoctorId);
            return doctor;
        }

        public async Task<bool> DeleteDoctor(Guid DoctorId)
        {
            var doctor= await GetDoctorById(DoctorId);
            if(doctor==null){
                return false;
            }
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Doctor>> GetAllDoctors()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Doctor> UpdateDoctor(Guid DoctorId, UpdateDoctorDto dto)
        {
            var doctor=  await GetDoctorById(DoctorId);
            if(doctor==null){
                return null;
            }
            doctor.Bio=dto.Bio;
            doctor.Degree=dto.Degree;
            doctor.Experience=dto.Experience;
            doctor.Ratings=dto.Ratings;
            doctor.Location=dto.Location;
            await _context.SaveChangesAsync();
            return  doctor;
        }
    }
}
