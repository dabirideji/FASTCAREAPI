using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dependencies.Interfaces.IRepositories;
using FastCare.Application.Dtos.Drug.Request;
using FastCare.Domain.Models;
using FastCare.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FastCare.Infrastructure.Repositories
{
    public class DrugRepository : IDrugRepository
    {
        private readonly IMapper _mapper;
        private readonly FastCareDbContext _context;

        public DrugRepository(IMapper mapper,FastCareDbContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public async Task<Drug> AddDrug(CreateDrugDto dto)
        {
            var drug=_mapper.Map<Drug>(dto);
            await _context.Drugs.AddAsync(drug);
            await  _context.SaveChangesAsync();
            return drug;
            
        }

 public async Task<Drug> GetDrugById(Guid DrugId)
        {
            return await _context.Drugs.FindAsync(DrugId);
        }
        public async Task<bool> DeleteDrug(Guid DrugId)
        {
            var drug= await GetDrugById(DrugId);
            if(drug==null){
                return false;
            }
            _context.Drugs.Remove(drug);
           await _context.SaveChangesAsync();
           return true;
        }

        public async Task<IEnumerable<Drug>> GetAllDrugs()
        {
            return await _context.Drugs.ToListAsync();
        }

       

        public async Task<Drug> UpdateDrug(Guid DrugId, UpdateDrugDto dto)
        {
             var drug= await GetDrugById(DrugId);
            if(drug==null){
                return null;
            }
            drug.DrugName=dto.DrugName;
            drug.DrugDescription=dto.DrugDescription;
            drug.DrugManufacturer=drug.DrugManufacturer;
            drug.DrugPrice=dto.DrugPrice;
            drug.DrugVolume=dto.DrugVolume;
            drug.DrugImage=dto.DrugImage;
            drug.UpdatedAt=DateTime.Now;
            drug.DrugWeight=dto.DrugWeight;
           await _context.SaveChangesAsync();
           return drug;
        }
    }
}