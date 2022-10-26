using Microsoft.AspNetCore.Mvc;

namespace ControllerChanges.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastControllerOld : ControllerBase
    {
       
        private readonly VerySpecificWeatherService _weatherService;

        public WeatherForecastControllerOld(VerySpecificWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet(Name = "GetWeatherForecastOld")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherService.GetWeatherForecast();
        }

    }
}