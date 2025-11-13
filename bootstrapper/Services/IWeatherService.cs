namespace bootstrapper.Services;

public interface IWeatherService
{
    WeatherForecast[] GetWeatherForecast();
}