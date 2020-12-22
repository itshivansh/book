using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using favouriteAPI.Exceptions;
using favouriteAPI.Models;
using favouriteAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace favouriteAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private readonly IFavouriteService _service;
        public FavouriteController(IFavouriteService service)
        {
            _service = service;
        }
        // GET: api/<FavouriteController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_service.GetFavourites());
            }
            catch (DatabaseNotFound ex)
            {
                return Conflict(ex.Message);
            }
        }
        //[EnableCors("Policy1")]
        [HttpGet("{id:int}")]
        public IActionResult GetFavourite(int id)
        {
            try
            {
                return Ok( _service.GetFavourite(id));
            }
            catch (DatabaseNotFound ex)
            {
                return Conflict(ex.Message);
            }
        }
       
        //[EnableCors("Policy2")]
        [HttpPost]
        [Route("Add")]
        public IActionResult AddFavourite([FromBody] Favourite fav)
        {
            try
            {
                _service.AddFavourite(fav);
                return Created("api/favourite", 201);
                // return Created("", _service.AddFavourite(fav));
            }
            catch (AlreadyFavourite ex)
            {
                return Conflict(ex.Message);
            }
            //catch
            //{
            //    return StatusCode(500, "Internal Server Error");
            //}
        }
       // [EnableCors("Policy3")]
        [HttpDelete("{id:int}/{title}")]
        public IActionResult Delete(int id, string title)
        {
            try
            {
                _service.DeleteFavourite(id, title);
                return StatusCode(201, "favourite deleted!!");
            }
            catch (DatabaseNotFound ex)
            {
                return Conflict(ex.Message);
            }
        }
    }
}
