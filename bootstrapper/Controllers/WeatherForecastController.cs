using bootstrapper.Services;
using Microsoft.AspNetCore.Mvc;

namespace bootstrapper.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherService _weatherService;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherService weatherService,ILogger<WeatherForecastController> logger)
    {
        _weatherService = weatherService;
        _logger = logger;
    }





    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        _logger.LogInformation("Fetching weather forecast");
        return _weatherService.GetWeatherForecast();
    }
}