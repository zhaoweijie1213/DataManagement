using DataManagement.Entity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DataManagement.Web.Controllers
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

        private readonly SystemDbContext _systemDbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, SystemDbContext systemDbContext)
        {
            _logger = logger;
            _systemDbContext = systemDbContext;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            using (var context= _systemDbContext)
            {
                var menu = context.SysMenus.Where(i => i.Pageid == 1).FirstOrDefault();
                _logger.LogInformation("{menu}", JsonConvert.SerializeObject(menu));
            }

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}