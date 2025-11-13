using bootstrapper.Services;
using JetBrains.Annotations;
using Xunit;

namespace bootstrapper.Tests.Services;

[TestSubject(typeof(WeatherService))]
public class WeatherServiceTest
{
    

    [Fact]
    public void getweathers_givenGetWeatherIsCalled_WeatherReportsShouldBeGenerated()
    {
        // Arrange
        var weatherService = new WeatherService();

        // Act
        var result = weatherService.GetWeatherForecast();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Length);
    }
    
    [Fact]
    public void getweathers_givenGetWeatherIsCalled_WeatherReportsShouldHaveValidTemperatures()
    {
        // Arrange
        var weatherService = new WeatherService();

        // Act
        var result = weatherService.GetWeatherForecast();

        // Assert
        foreach (var weather in result)
        {
            Assert.InRange(weather.TemperatureC, -20, 55);
        }
    }
}