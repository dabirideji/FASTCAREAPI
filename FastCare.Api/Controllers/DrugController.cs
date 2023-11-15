using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dependencies.Helpers.AutoResponses;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Drug.Request;
using FastCare.Application.Dtos.Drug.Response;
using FastCare.Application.Dtos.Response;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FastCare.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DrugController : ControllerBase
    {
        private readonly IDrugService _service;

        public DrugController(IDrugService service)
        {
            _service = service;
        }

        private AutoDefaultResponse<ReadDrugDto> x = new();

        [HttpPost("AddDrug")]
        public async Task<ActionResult<DefaultResponse<ReadDrugDto>>> AddDrug([FromBody]CreateDrugDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var drug = await _service.AddDrug(dto);
                if (drug == null)
                {
                    return BadRequest(x.ConvertToBad("ERROR ADDING DRUG"));
                }
                var response = x.ConvertToGood("DRUG ADDED SUCCESSFULLY");
                response.Data = drug;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpGet("GetAllDrugs")]
        public async Task<ActionResult<DefaultResponse<IEnumerable<ReadDrugDto>>>> GetAllDrugs()
        {
            var x = new AutoDefaultResponse<IEnumerable<ReadDrugDto>>();
            try
            {
                var drugs = await _service.GetAllDrugs();
                if (drugs == null || drugs.Count() == 0)
                {
                    return NotFound(x.ConvertToBad("NO DRUGS FOUND"));
                }
                var response = x.ConvertToGood("DRUGS FOUND SUCCESSFULLY");
                response.Data = drugs;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpGet("GetDrugById/{DrugId}")]
        public async Task<ActionResult<DefaultResponse<ReadDrugDto>>> GetDrugById(
            [FromRoute] Guid DrugId
        )
        {
            try
            {
                var drug = await _service.GetDrugById(DrugId);
                if (drug == null)
                {
                    return NotFound(x.ConvertToBad("DRUG NOT FOUND"));
                }
                var response = x.ConvertToGood("DRUG FOUND SUCCESSFULLY");
                response.Data = drug;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpPost("UpdateDrug/{DrugId}")]
        public async Task<ActionResult<DefaultResponse<ReadDrugDto>>> UpdateDrug(
            [FromRoute] Guid DrugId,
            [FromBody] UpdateDrugDto dto
        )
        {
            try
            {
                var drug = await _service.UpdateDrug(DrugId, dto);
                if (drug == null)
                {
                    return BadRequest(x.ConvertToBad("UNABLE TO UPDATE DRUG"));
                }
                var response = x.ConvertToGood("DRUG UPDATED SUCCESSFULLY");
                response.Data = drug;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpPost("DeleteDrug/{DrugId}")]
        public async Task<ActionResult<DefaultResponse<ReadDrugDto>>> DeleteDrug(
            [FromRoute] Guid DrugId
        )
        {
            try
            {
                var drug = await _service.DeleteDrug(DrugId);
                if (drug == false)
                {
                    return BadRequest(x.ConvertToBad("UNABLE TO DELETE DRUG"));
                }
                var response = x.ConvertToGood("DRUG DELETED SUCCESSFULLY");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }
    }
}
