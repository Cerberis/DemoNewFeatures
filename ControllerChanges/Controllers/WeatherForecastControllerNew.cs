using Microsoft.AspNetCore.Mvc;

namespace ControllerChanges.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastControllerNew : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get([FromServices]VerySpecificWeatherService weatherService)
        {
            return weatherService.GetWeatherForecast();
        }
    }
}