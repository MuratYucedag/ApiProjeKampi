using ApiProjeKampi.WebApi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly ApiContext _context;
        public StatisticsController(ApiContext context)
        {
            _context = context;
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            var value = _context.Products.Count();
            return Ok(value);
        }

        [HttpGet("ReservationCount")]
        public IActionResult ReservationCount()
        {
            var value = _context.Reservations.Count();
            return Ok(value);
        }

        [HttpGet("ChefCount")]
        public IActionResult ChefCount()
        {
            var value = _context.Chefs.Count();
            return Ok(value);
        }

        [HttpGet("TotalGuestCount")]
        public IActionResult TotalGuestCount()
        {
            var value = _context.Reservations.Sum(x => x.CountofPeople);
            return Ok(value);
        }
    }
}
