using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Domain.Models;

namespace FastCare.Application.Dependencies.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repo;

        public DoctorService(IDoctorRepository repo)
        {
            _repo = repo;
        }

        public Task<Doctor> CreateDoctor(CreateDoctorDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteDoctor(Guid DoctorId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Doctor>> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> GetDoctorById(Guid DoctorId)
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> UpdateDoctor(Guid DoctorId, UpdateDoctorDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
