using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleMathAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleMathController : ControllerBase
    {
        private readonly ILogger<SimpleMathController> _logger;

        public SimpleMathController(ILogger<SimpleMathController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("/divisores/{valorMaximo}")]
        public IEnumerable<int> GetDivisores(int valorMaximo)
        {
            return MathUtils.NumerosDivisores(valorMaximo);
        }

        [HttpGet]
        [Route("/numerosprimos/{valorMaximo}")]
        public IEnumerable<int> GetNumerosPrimos(int valorMaximo)
        {
            return MathUtils.NumerosPrimos(MathUtils.NumerosDivisores(valorMaximo));
        }
    }
}
