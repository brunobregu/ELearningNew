using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ELearningProject.Models
{
    public class Kursi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required, Column(TypeName = "VARCHAR")]
        public string EmriKursit { get; set; }
        [Required, Column(TypeName = "VARCHAR"), MinLength(5)]
        public string Pershkrimi { get; set; }
        [Required]
        [Display(Name = "Imazhi Kursit")]
        public string ImagePath { get; set; }
        [ScaffoldColumn(false)]
        public DateTime? CreatedOn { get; set; }
        public ICollection<UserToKursi> UserToKursi { get; set; }
        public ICollection<Materials> Materials { get; set; }
    }
}