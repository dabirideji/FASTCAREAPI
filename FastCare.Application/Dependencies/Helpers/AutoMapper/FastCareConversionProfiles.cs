using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;
using FastCare.Application.Dtos.Drug.Request;
using FastCare.Application.Dtos.Drug.Response;
using FastCare.Application.Dtos.Facility.Request;
using FastCare.Application.Dtos.Facility.Response;
using FastCare.Domain.Models;

namespace FastCare.Application.Dependencies.Helpers.AutoMapper
{
    public class FastCareConversionProfiles:Profile
    {
        public FastCareConversionProfiles()
        {
            //DOCTOR AUTOMAPPED PROFILE, FOR CONVERSION OF THE DOCTORS
            CreateMap<CreateDoctorDto,Doctor>();
            CreateMap<UpdateDoctorDto,Doctor>();
            CreateMap<Doctor,ReadDoctorDto>();


            //PROIFLE FOR DRUG
             CreateMap<CreateDrugDto,Drug>();
            CreateMap<UpdateDrugDto,Drug>();
            CreateMap<Drug,ReadDrugDto>();



            //PROIFLE FOR FACILITIES
             CreateMap<CreateFacilityDto,Facility>();
            CreateMap<UpdateFacilityDto,Facility>();
            CreateMap<Facility,ReadFacilityDto>();
        }
        
    }
}