using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecommendationAPI.Models;
using RecommendationAPI.Services;
using RecommendationAPI.Utilities;

namespace RecommendationAPI.Controllers
{
    //[Authorize]
    [ExceptionHandler]
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendController : ControllerBase
    {
        private readonly IRecommendService service;

        public RecommendController(IRecommendService _service)
        {
            this.service = _service;
        }
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok(service.GetRecommandsById(id));
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetRecommends());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Recommend value)
        {
            return Created("", service.AddRecommands(value));
        }
        [HttpDelete("{id:int}/{title:string}")]
        public IActionResult Delete(int id,string title)
        {
            return Ok(service.RemoveRecommend(id,title));
        }
    }
}
