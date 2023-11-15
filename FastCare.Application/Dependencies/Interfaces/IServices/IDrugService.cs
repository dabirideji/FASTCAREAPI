using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dtos.Drug.Request;
using FastCare.Application.Dtos.Drug.Response;

namespace FastCare.Application.Dependencies.Interfaces.IServices
{
    public interface IDrugService
    {
        Task<ReadDrugDto> AddDrug(CreateDrugDto dto);
        Task<IEnumerable<ReadDrugDto>> GetAllDrugs();
        Task<ReadDrugDto> GetDrugById(Guid DrugId);
        Task<ReadDrugDto> UpdateDrug(Guid DrugId,UpdateDrugDto dto);
        Task<bool> DeleteDrug(Guid DrugId);
    }
}