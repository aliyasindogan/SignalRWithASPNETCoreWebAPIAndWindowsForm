using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.HubConfig;
using Entities;
using Microsoft.AspNetCore.SignalR;

namespace Bussines.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IHubContext<WeatherForecastHub> _hub;

        public WeatherForecastService(IHubContext<WeatherForecastHub> hub)
        {
            _hub = hub;
        }

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public async Task GetData()
        {
            var rng = new Random();
            var data = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();
            var timerManager = new TimerService(() => _hub.Clients.All.SendAsync("transferdata", data));
        }
    }
}