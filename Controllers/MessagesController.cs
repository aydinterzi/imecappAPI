using imecappAPI.DTO;
using imecappAPI.Models;
using imecappAPI.PostData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace imecappAPI.Controllers
{
    [Authorize]
    [Route("api/Posts/[controller]/{userId}")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IPostData _sqlPostData;
        public MessagesController(IPostData sqlPostData)
        {
            _sqlPostData = sqlPostData;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(int userId,MessageForCreateDTO messageForCreateDTO)
        {
            if (userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            messageForCreateDTO.SenderId = userId;
            var recipient = await _sqlPostData.GetUser(messageForCreateDTO.RecipientId);
            if (recipient == null)
                return BadRequest("mesaj göstermek istediginiz kullanıcı yok.");

            var message = new Messages
            {
                SenderId = userId,
                RecipientId = messageForCreateDTO.RecipientId,
                Text = messageForCreateDTO.Text
            };
            _sqlPostData.AddMessage(message);
            
            return Ok(messageForCreateDTO);
        }
    }
}
