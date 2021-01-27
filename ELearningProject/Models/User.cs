using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ELearningProject.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, MinLength(3), Index(IsUnique = true), Column(TypeName = "VARCHAR")]
        public string Emri { get; set; }
        [Required, MinLength(3), Index(IsUnique = true), Column(TypeName = "VARCHAR")]
        public string Mbiemri { get; set; }

        [Required, MinLength(5), Index(IsUnique = true), Column(TypeName = "VARCHAR")]
        public string Username { get; set; }

        [MinLength(5), Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [EmailAddress, Index(IsUnique = true), Column(TypeName = "VARCHAR"), Required]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "My Picture")]
        public string ImageUrl { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedOn { get; set; }
        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual UserRole UserRole { get; set; }
        public ICollection<UserToKursi> UserToKursi { get; set; }
        public ICollection<Reply> Reply { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}