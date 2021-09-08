using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.Models
{
    public class User:IdentityUser<int>
    {
        public List<Post> Posts  { get; set; }
        public List<Messages> MessagesSent { get; set; }
        public List<Messages> MessagesReceived { get; set; }
    }
}
