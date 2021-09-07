using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.Models
{
    public class PostQueryParams
    {
        public int PostId { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public string progLanguage { get; set; }
    }
}
