using Microsoft.AspNetCore.Mvc;
using Sample.API.Configurations.Filters;

namespace Sample.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ActionFilterAttribute("DriverController")]
    public class DriverController : ControllerBase
    {
        private static readonly List<string> Drivers = new()
        {
            "Name Test 10",
            "Name Test 12",
            "Name Test 13",
            "Name Test 14"
        };

        [HttpGet("getdrivers")]
        public IActionResult Get()
        {
            return Ok(Drivers);
        }

        [HttpPost("adddrivers")]
        public IActionResult Post(string drivername)
        {
            Drivers.Add(drivername);
            return Ok();
        }
    }

     
}
