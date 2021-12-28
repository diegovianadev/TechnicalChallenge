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

        /// <summary>
        /// Technical Challenge
        /// </summary>
        /// <param name="enterNumber">Número que será encontrado seus divisores e quais são primos</param>
        /// <returns>Lista de divisores e quais são primos</returns>
        /// <response code="200">retorna lista de divisores e quais deles são primos.</response>
        /// <response code="400">Parâmetro inválido</response>
        [HttpGet]
        public DivisorParameter Get(int enterNumber)
        {
            var result = Divisor.GetPrimesAndDivisorsNumbers(new DivisorParameter(enterNumber));
            return (result);
        }
    }
}