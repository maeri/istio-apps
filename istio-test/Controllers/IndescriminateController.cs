using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace istio_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndescriminateController : ControllerBase
    {
        IConfiguration _configuration;
        public IndescriminateController(IConfiguration configuration)
        {
            _configuration = configuration;

        }
        [HttpGet]
        public ActionResult<string>Get()
        {
            return Ok($"dong {_configuration["Version"]}");
        }
    }
}