using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dtos.Drug.Request;
using FastCare.Domain.Models;

namespace FastCare.Application.Dependencies.Interfaces.IRepositories
{
    public interface IDrugRepository
    {
        Task<Drug> AddDrug(CreateDrugDto dto);
        Task<IEnumerable<Drug>> GetAllDrugs();
        Task<Drug> GetDrugById(Guid DrugId);
        Task<Drug> UpdateDrug(Guid DrugId,UpdateDrugDto dto);
        Task<bool> DeleteDrug(Guid DrugId);

    }
}