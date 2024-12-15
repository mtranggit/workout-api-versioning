using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using workout_with_versioning.Controllers.V1.Models;

namespace workout_with_versioning.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class WorkoutsController : Controller
    {
        [MapToApiVersion("1.0")]
        [HttpGet("{id}")]
        public IActionResult GetV1(int id)
        {
            var workout = new WorkoutV1 { Id = id, Name = "This is version 1.0" };
            return Ok(workout);
        }
    }
}
