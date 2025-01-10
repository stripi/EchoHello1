using Microsoft.AspNetCore.Mvc;

namespace Container.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/getweatherforecast")]
        public IActionResult Get()
        {
            //    var weatherList =  Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //    {
            //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //        TemperatureC = Random.Shared.Next(-20, 55),
            //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //    })
            //    .ToList();
            //    if(weatherList != null)
            //        return Ok(weatherList);
            string weather = "weather is great";
            return Ok(weather);
        }

    }
}
