using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PublishSubscribeExampleWithObserverPattern.Concrete;

namespace PublishSubscribeExampleWithObserverPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void Get()
        {
            FootballMatch match = new FootballMatch("Italia", "Germania");
            SimpleObserver o1 = new SimpleObserver("1", match);
            SimpleObserver o2 = new SimpleObserver("2", match);
            LogObserver o3 = new LogObserver(match);

            match.Attach(o1);
            match.Attach(o2);
            match.Attach(o3);

            match.UpdateScore(14, 1, 0);
            match.UpdateScore(65, 2, 0);

            o3.PrintHistory();

        }
    }
}
