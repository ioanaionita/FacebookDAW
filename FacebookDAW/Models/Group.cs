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
        private int id { get; set; }
        private string name { get; set; }
        private DateTime createdDate { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<User> Admins { get; set; }
    }
}