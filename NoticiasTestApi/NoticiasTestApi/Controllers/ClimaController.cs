using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticiasTestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimaController : ControllerBase
    {
        [HttpGet("{city_name}")]
        public IActionResult Get(string city_name)
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=" + city_name + "&appid=7443e56f98f834a84f54830391c2b854";
            WebRequest wrUrl = WebRequest.Create(url);
            WebResponse wrpGet = wrUrl.GetResponse();
            StreamReader sr = new StreamReader(wrpGet.GetResponseStream());
            return Ok(sr.ReadToEnd().Trim());
        }
    }
}
