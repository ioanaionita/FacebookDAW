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
        private int id { get; set; }
        private string content { get; set; }
        public int userId { get; set; }
        private DateTime dateCreated { get; set; }
        public virtual User User { get; set; }
    }
}