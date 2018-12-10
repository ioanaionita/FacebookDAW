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
        private int id { get; set; }
        public int senderId { get; set; }
        public virtual User Sender { get; set; }
        private DateTime sendDate { get; set; }
        public int chatId { get; set; }
        public virtual Chat Chat { get; set; }
        
    }
}