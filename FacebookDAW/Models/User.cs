using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FacebookDAW.Models
{
    public class User
    {
        [Key]
        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private DateTime dateOfBirth { get; set; }
        private string city { get; set; }
        private string country { get; set; }
        private Boolean profileVisibility { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<User> Friends { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
    }
}