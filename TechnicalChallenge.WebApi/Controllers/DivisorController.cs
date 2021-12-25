using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DivisorLibrary;

namespace TechnicalChallenge.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisorController : ControllerBase
    {
        private readonly ILogger<DivisorController> _logger;

        public DivisorController(ILogger<DivisorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public DivisorParameter Get(int enterNumber)
        {
            var result = Divisor.NumberValidator(enterNumber);
            return (result);
        }

    }
}