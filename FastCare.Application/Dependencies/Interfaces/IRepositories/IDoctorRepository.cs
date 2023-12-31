using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;

namespace FastCare.Application.Dependencies.Interfaces.IRepositories
{
    public interface IDoctorRepository
    {
        
        Task<Doctor> CreateDoctor(CreateDoctorDto dto);
        Task<IEnumerable<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorById(Guid DoctorId);
        Task<Doctor> UpdateDoctor(Guid DoctorId,UpdateDoctorDto dto);
        Task<bool> DeleteDoctor(Guid DoctorId);
    }
}