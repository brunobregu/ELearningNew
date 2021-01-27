using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningProject.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public string Roli { get; set; }
        public ICollection<User> User { get; set; }
    }
}