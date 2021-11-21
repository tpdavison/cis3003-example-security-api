using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecureApi.Models;

namespace SecureApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var rand = new Random().Next();
            var value = new GetValuesDto
            {
                Number = rand,
                Message = $"Hello, your result is {rand}."
            };
            return Ok(value);
        }
    }
}
