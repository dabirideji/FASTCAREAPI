using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;
using FastCare.Application.Dependencies.Interfaces.IRepositories;

namespace FastCare.Infrastructure.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
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