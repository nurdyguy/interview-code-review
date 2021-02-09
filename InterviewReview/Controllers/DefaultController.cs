using Microsoft.AspNetCore.Mvc;
using System;

namespace InterviewReview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        /// <summary>
        /// Entry point for the review
        ///
        /// Feel free to modify this method as needed but the input,
        /// route, Http Verb and controller route need to remain static
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>Status Code 200 with a calculated result</returns>
        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] int[][] grid)
        {
            throw new NotImplementedException();
        }
    }
}
