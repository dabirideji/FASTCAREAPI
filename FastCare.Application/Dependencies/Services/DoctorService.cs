using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;
using FastCare.Domain.Models;

namespace FastCare.Application.Dependencies.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _repo;
        private readonly IMapper _mapper;

        public DoctorService(IDoctorRepository repo,IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<ReadDoctorDto> CreateDoctor(CreateDoctorDto dto)
        {
            var doctor=await _repo.CreateDoctor(dto);
            if(doctor==null){
                return null;
            }
            var doctorDto=_mapper.Map<ReadDoctorDto>(doctor);
            return doctorDto;

        }

        public async Task<bool> DeleteDoctor(Guid DoctorId)
        {
            return await _repo.DeleteDoctor(DoctorId);
        }

        public async Task<IEnumerable<ReadDoctorDto>> GetAllDoctors()
        {
            var doctors=await _repo.GetAllDoctors();
            if(doctors==null){
                return null;
            }
            var doctorsDto=doctors.Select(x=>_mapper.Map<ReadDoctorDto>(x));
            return doctorsDto;
        }

        public async Task<ReadDoctorDto> GetDoctorById(Guid DoctorId)
        {
            var  doctor=await _repo.GetDoctorById(DoctorId);
            if(doctor==null){
                return null;
            }
            var doctorDto=_mapper.Map<ReadDoctorDto>(doctor);
            return doctorDto;
        }

        public async Task<ReadDoctorDto> UpdateDoctor(Guid DoctorId, UpdateDoctorDto dto)
        {
            var doctor= await _repo.UpdateDoctor(DoctorId,dto);
            if(doctor==null){
                return null;
            }
            var doctorDto=_mapper.Map<ReadDoctorDto>(doctor);
            return doctorDto;
        }
    }
}
