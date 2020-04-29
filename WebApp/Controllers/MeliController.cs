using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Core.Aplication.Interfaces;

namespace WebApp.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Produces("application/json",
              "application/xml")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class MeliController : Controller
    {
        public IMeliService _meliService { get; }
        public MeliController(IMeliService meliService)
        {
            _meliService = meliService;
        }

               
        [HttpGet("{userId}/user")]      
        public async Task<IActionResult> GetUser(long userId)
        {
            var user = await _meliService.GetMeliUser(userId);
           return Ok(user);
        }
    }
}