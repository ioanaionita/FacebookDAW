using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookDAW.Models
{
    public class Message
    {
        [Key]
        private int Id { get; set; }
        public int SenderId { get; set; }
        public virtual User Sender { get; set; }
        private DateTime SendDate { get; set; }
        public int ChatId { get; set; }
        public virtual Chat Chat { get; set; }
        
    }
}