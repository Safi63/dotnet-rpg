using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RandomController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Random rnd = new Random();
  
            return Ok(rnd.Next());
        }
    }
}
