using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookDAW.Models
{
    public class Comment
    {
        [Key]
        private int Id { get; set; }
        private string Content { get; set; }
        public int UserId { get; set; }
        private DateTime DateCreated { get; set; }
        public virtual User User { get; set; }
    }
}