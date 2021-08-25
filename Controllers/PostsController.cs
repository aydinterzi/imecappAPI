using imecappAPI.PostData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostData _sqlPostData;
        public PostsController(IPostData sqlPostData)
        {
            _sqlPostData = sqlPostData;
        }
        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            return Ok(await _sqlPostData.GetEmployees());
        }

    }
}
