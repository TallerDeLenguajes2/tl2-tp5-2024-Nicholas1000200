using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;

namespace tl2_tp5_2024_Nicholas1000200.Controllers;

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

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        using (var sqlitecon = new SqliteConnection("Data Source=db/Tienda.db"))
        {
            sqlitecon.Open();
            
            sqlitecon.Close();
        }
    }
}
