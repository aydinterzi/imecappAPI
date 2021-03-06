using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace imecappAPI.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public int? SenderId { get; set; }
        public User Sender { get; set; }
        public int? RecipientId { get; set; }
        public User Recipient { get; set; }
        public string Text { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateRead { get; set; }
        public bool IsRead { get; set; }
        public bool SenderDeleted { get; set; }
        public bool RecipientDeleted { get; set; }


    }
}
