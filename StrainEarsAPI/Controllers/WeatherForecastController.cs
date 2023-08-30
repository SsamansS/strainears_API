﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StrainEarsDB;
using StrainEarsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace StrainEarsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[EnableCors(origins: "https://localhost:44386", headers: "*", methods: "*")]
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
        [DisableCors]
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
        [DisableCors]
        public IEnumerable<string> GetPlaylistsByUser()
        {
            //return StrainEarsDbCommands.GetPlaylistsByUserId(userId);
            return new List<string>() { };
        }
    }
}
