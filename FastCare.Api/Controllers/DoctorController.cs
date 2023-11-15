using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastCare.Application.Dependencies.Helpers.AutoResponses;
using FastCare.Application.Dependencies.Interfaces.IServices;
using FastCare.Application.Dtos.Doctor.Request;
using FastCare.Application.Dtos.Doctor.Response;
using FastCare.Application.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace FastCare.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private AutoDefaultResponse<ReadDoctorDto> x = new();
        private readonly IDoctorService _service;

        public DoctorController(IDoctorService service)
        {
            _service = service;
        }

        [HttpPost("CreateDoctor")]
        public async Task<ActionResult<DefaultResponse<ReadDoctorDto>>> CreateDoctor(
            CreateDoctorDto dto
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var doctor = await _service.CreateDoctor(dto);
                if (doctor == null)
                {
                    return BadRequest(x.ConvertToBad("UNABLE TO CREATE DOCTOR"));
                }
                var response = x.ConvertToGood("DOCTOR CREATED SUCCESSFULLY");
                response.Data = doctor;
                return StatusCode(201, response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpGet("GetAllDoctors")]
        public async Task<ActionResult<DefaultResponse<IEnumerable<ReadDoctorDto>>>> GetAllDoctors()
        {
            try
            {
                var doctors = await _service.GetAllDoctors();
                var x = new AutoDefaultResponse<IEnumerable<ReadDoctorDto>>();
                if (doctors == null||doctors.Count()==0)
                {
                    return NotFound(x.ConvertToBad("NO DOCTORS FOUND"));
                }
                var response = x.ConvertToGood("DOCTORS FOUND SUCCESSFULLY");
                response.Data = doctors;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }

        [HttpGet("GetDoctorById/{DoctorId}")]
        public async Task<ActionResult<DefaultResponse<ReadDoctorDto>>> GetDoctorById(
            [FromRoute] Guid DoctorId
        )
        {
            try
            {
                var doctor = await _service.GetDoctorById(DoctorId);
                if (doctor == null)
                {
                    return NotFound(x.ConvertToBad("DOCTOR NOT FOUND"));
                }
                var response = x.ConvertToGood("DOCTOR FOUND SUCCESSFULLY");
                response.Data = doctor;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }
        [HttpDelete("DeleteDoctor/{DoctorId}")]
        public async Task<ActionResult<DefaultResponse<ReadDoctorDto>>> DeleteDoctor(
            [FromRoute] Guid DoctorId
        )
        {
            try
            {
                var doctor = await _service.DeleteDoctor(DoctorId);
                if (doctor == false)
                {
                    return NotFound(x.ConvertToBad("UNABLE TO DELETE DOCTOR"));
                }
                var response = x.ConvertToGood("DOCTOR DELETED SUCCESSFULLY");
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
        }


[HttpPut("UpdateDoctor/{DoctorId}")]
public async Task<ActionResult<DefaultResponse<ReadDoctorDto>>> UpdateDoctor([FromRoute]Guid DoctorId,UpdateDoctorDto dto){
     try
            {
                var doctor = await _service.UpdateDoctor(DoctorId,dto);
                if (doctor == null)
                {
                    return NotFound(x.ConvertToBad("UNABLE TO UPDATE DOCTOR"));
                }
                var response = x.ConvertToGood("DOCTOR UPDATED SUCCESSFULLY");
                response.Data=doctor;
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode(500, x.ConvertToBad($"{ex.Message}"));
            }
}

    }
}
