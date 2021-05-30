﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Tests.Assets.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReturnTypeController : ControllerBase
    {

        [HttpGet("RouteA")]
        public IEnumerable<WeatherForecast> Simple()
        {
            return null;
        }

        [HttpDelete]
        public async Task<ActionResult<IEnumerable<WeatherForecast>>> TaskAndActionResult()
        {
            return await System.Threading.Tasks.Task.FromResult<ActionResult<IEnumerable<WeatherForecast>>>(null);
        }

        [HttpPut]
        public ActionResult<IEnumerable<WeatherForecast>> ActionResult()
        {
            return null;
        }       

        [HttpPost]
        public async Task<IEnumerable<WeatherForecast>> Task()
        {
            return await System.Threading.Tasks.Task.FromResult<IEnumerable<WeatherForecast>>(null);
        }

        [HttpGet("RouteB")]
        [ProducesResponseType(typeof(IEnumerable<WeatherForecast>), StatusCodes.Status200OK)]
        public async Task<IEnumerable<WeatherForecast>> ProducesResponseType()
        {
            return await System.Threading.Tasks.Task.FromResult<IEnumerable<WeatherForecast>>(null);
        }
    }
}