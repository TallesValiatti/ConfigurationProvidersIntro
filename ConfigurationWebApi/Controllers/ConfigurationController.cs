using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ConfigurationWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ConfigurationController(IConfiguration configuration)
        {
            _configuration = configuration;    
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            var value = _configuration.GetSection("key").Value;
            return Ok(new { key = value});
        }
    }
}