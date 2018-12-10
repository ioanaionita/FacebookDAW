using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookDAW.Models
{
    public class Album
    {
        [Key]
        private int Id { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}