using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookDAW.Models
{
    public class Photo
    {
        [Key]
        private int id { get; set; }
        private string description { get; set; }
        public int albumId { get; set; }
        
        public virtual Album Album { get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }

    }
}