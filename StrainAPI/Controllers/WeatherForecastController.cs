using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StrainEarsDB;
using StrainEarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrainAPI.Controllers
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet]
        [Route("/Playlists/{userId}")]
        public IEnumerable<Playlist> GetPlaylists(int userId)
        {
            return StrainEarsDbCommands.GetPlaylistsByUserId(userId);
        }

        [HttpGet]
        [Route("/Tracks")]
        public IEnumerable<Track> GetTracks()
        {
            return StrainEarsDbCommands.GetAllTracks();
        }

        [HttpPut]
        public IActionResult RegistrationUser([FromBody] User userInfo)
        {
            StrainEarsDbCommands.RegistrationUser(userInfo);
            return Ok();
        }
    }
}
