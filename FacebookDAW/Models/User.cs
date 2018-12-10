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
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }
        private string City { get; set; }
        private string Country { get; set; }
        private Boolean ProfileVisibility { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<User> Friends { get; set; }
        public virtual ICollection<Chat> Chats { get; set; }
    }
}