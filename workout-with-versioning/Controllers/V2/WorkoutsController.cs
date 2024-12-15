using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using workout_with_versioning.Controllers.V2.Models;

namespace workout_with_versioning.Controllers.V2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class WorkoutsController : Controller
    {

        [MapToApiVersion("2.0")]
        [HttpGet("{id}")]
        public IActionResult GetV2(int id)
        {
            var workout = new WorkoutV2{ Id = id, Name = "This is version 2.0", Description = "New Field Data added in V2" };
            return Ok(workout);
        }
    }
}
