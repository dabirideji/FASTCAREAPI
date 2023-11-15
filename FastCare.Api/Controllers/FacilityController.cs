using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FastCare.Application.Dependencies.Helpers.AutoResponses;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Facility.Request;
using FastCare.Application.Dtos.Facility.Response;
using FastCare.Application.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace FastCare.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FacilityController : ControllerBase
    {
        private readonly IFacilityService _service;
        private readonly IMapper _mapper;

        private AutoDefaultResponse<ReadFacilityDto> x = new();

        public FacilityController(IFacilityService service, IMapper mapper)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpPost("AddFacility")]
        public async Task<ActionResult<DefaultResponse<ReadFacilityDto>>> AddFacility(
            [FromBody]CreateFacilityDto dto
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var facility = await _service.CreateFacility(dto);
                if (facility == null)
                {
                    return BadRequest(x.ConvertToBad("UNABLE TO CREATE FACILITY"));
                }
                var response = x.ConvertToGood("FACILITY CREATED SUCCESSFULLY");
                response.Data = facility;
                return StatusCode(201, response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpGet("GetAllFacilities")]
        public async Task<
            ActionResult<DefaultResponse<IEnumerable<ReadFacilityDto>>>
        > GetAllFacilities()
        {
            var x = new AutoDefaultResponse<IEnumerable<ReadFacilityDto>>();
            try
            {
                var facilities = await _service.GetAllFacilities();
                if (facilities == null || facilities.Count() == 0)
                {
                    return NotFound(x.ConvertToBad("NO FACILITY FOUND"));
                }
                var response = x.ConvertToGood("FACILITIES FOUND SUCCESSFULLY");
                response.Data = facilities;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }
        [HttpGet("GetFacilityById/{FacilityId}")]
        public async Task<
            ActionResult<DefaultResponse<ReadFacilityDto>>
        > GetFacilityById([FromRoute]Guid FacilityId)
        {
            try
            {
                var facility = await _service.GetFacilityById(FacilityId);
                if (facility == null)
                {
                    return NotFound(x.ConvertToBad("FACILITY NOT FOUND"));
                }
                var response = x.ConvertToGood("FACILITY FOUND SUCCESSFULLY");
                response.Data = facility;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }
        [HttpDelete("DeleteFacility/{FacilityId}")]
        public async Task<
            ActionResult<DefaultResponse<ReadFacilityDto>>
        > DeleteFacility([FromRoute]Guid FacilityId)
        {
            try
            {
                var facility = await _service.DeleteFacility(FacilityId);
                if (facility == false)
                {
                    return BadRequest(x.ConvertToBad("UNABLE TO DELETE FACILITY"));
                }
                var response = x.ConvertToGood("FACILITY DELETED SUCCESSFULLY");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }
        [HttpPut("UpdateFacility/{FacilityId}")]
        public async Task<
            ActionResult<DefaultResponse<ReadFacilityDto>>
        > UpdateFacility([FromRoute]Guid FacilityId,[FromBody]UpdateFacilityDto dto)
        {
            try
            {
                var facility = await _service.UpdateFacility(FacilityId,dto);
                if (facility == null)
                {
                    return BadRequest(x.ConvertToBad("UNABLE TO UPDATE FACILITY"));
                }
                var response = x.ConvertToGood("FACILITY UPDATED SUCCESSFULLY");
                response.Data=facility;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }
    }
}
