using API.Attributes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiKeyAuth]
    [ApiController]
    [Route("[controller]")]
    public class SecurePointController : ControllerBase
    {
        public SecurePointController()
        {

        }

        [HttpGet("confidential")]
        public IActionResult GetConfidentialData()
        {
            return Ok("It is Ok.");
        }
    }
}
