using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
        public string progLanguage { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
