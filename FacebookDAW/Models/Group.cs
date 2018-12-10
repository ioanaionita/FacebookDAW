using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookDAW.Models
{
    public class Group
    {
        [Key]
        private int Id { get; set; }
        private string Name { get; set; }
        private DateTime CreatedDate { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<User> Admins { get; set; }
    }
}