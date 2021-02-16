using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _rentalService.GetAll();
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("GetRentalDetails")]
        public IActionResult GetRentalDetails(int carId)
        {
            var result = _rentalService.GetRentalDetailsDto(carId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpGet("CheckReturnDate")]
        public IActionResult CheckReturnDate(int carId)
        {
            var result = _rentalService.CheckReturnDate(carId);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("Add")]
        public IActionResult Add(Rental rental)
        {
            var result = _rentalService.Add(rental);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }
        [HttpPost("UpdateReturnDate")]
        public IActionResult UpdateReturnDate(int id)
        {
            var result = _rentalService.UpdateReturnDate(id);
            if (result.Success)
                return Ok(result);
            return BadRequest(result);
        }


    }
}
