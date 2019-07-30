using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace istio_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        IConfiguration _configuration;
        public VersionController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok($"ding {_configuration["Version"]}");
        }

       
       
        
    }
}
