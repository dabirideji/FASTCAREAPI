using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Domain.Models;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;

namespace FastCare.Application.Dependencies.Interfaces.IServices
{
    public interface IDoctorService
    {
        Task<ReadDoctorDto> CreateDoctor(CreateDoctorDto dto);
        Task<IEnumerable<ReadDoctorDto>> GetAllDoctors();
        Task<ReadDoctorDto> GetDoctorById(Guid DoctorId);
        Task<ReadDoctorDto> UpdateDoctor(Guid DoctorId,UpdateDoctorDto dto);
        Task<bool> DeleteDoctor(Guid DoctorId);
    }
}