using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication11.Repository;

namespace WebApplication11.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        private readonly IWeatherRepository _weatherRepository;


        public WeatherForecastController(IWeatherRepository weatherRepository, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _weatherRepository = weatherRepository;
        }

       

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
           return _weatherRepository.GetData();
        }
    }
}
