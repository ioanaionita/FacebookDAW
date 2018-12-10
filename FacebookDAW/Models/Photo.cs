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
        private int Id { get; set; }
        private string Description { get; set; }
        public int AlbumId { get; set; }
        
        public virtual Album Album { get; set; }
        public virtual ICollection<Comment> Comments{ get; set; }

    }
}