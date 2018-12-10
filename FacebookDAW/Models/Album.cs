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
        private int id { get; set; }
        public int userId { get; set; }

        public virtual User User { get; set; }
        public ICollection<Photo> Photos { get; set; }
    }
}