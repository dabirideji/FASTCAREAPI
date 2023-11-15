using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Drug.Request;
using FastCare.Application.Dtos.Drug.Response;

namespace FastCare.Application.Dependencies.Services
{
    public class DrugService : IDrugService
    {
        private readonly IDrugRepository _repo;
        private readonly IMapper _mapper;

        public DrugService(IDrugRepository repo,IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<ReadDrugDto> AddDrug(CreateDrugDto dto)
        {
            var drug=await _repo.AddDrug(dto);
            if(drug==null){
                return null;
            }
            var drugDto=_mapper.Map<ReadDrugDto>(drug);
            return drugDto;
        }
        public async Task<ReadDrugDto> GetDrugById(Guid DrugId)
        {
            var drug=await _repo.GetDrugById(DrugId);
            if(drug==null){
                return null;
            }
            var drugDto=_mapper.Map<ReadDrugDto>(drug);
            return drugDto;}
        public async Task<bool> DeleteDrug(Guid DrugId)
        {
            return await _repo.DeleteDrug(DrugId);
        }

        public async Task<IEnumerable<ReadDrugDto>> GetAllDrugs()
        {
            var drugs=await _repo.GetAllDrugs();
            if(drugs==null||drugs.Count()==0){
                return null;
            }
            var drugsDto=drugs.Select(x=>_mapper.Map<ReadDrugDto>(x));
            return drugsDto;
        }

        

        public async Task<ReadDrugDto> UpdateDrug(Guid DrugId, UpdateDrugDto dto)
        {
            var drug=await _repo.UpdateDrug(DrugId,dto);
            if(drug==null){
                return null;
            }
            var drugDto=_mapper.Map<ReadDrugDto>(drug);
            return drugDto;
        }
    }
}