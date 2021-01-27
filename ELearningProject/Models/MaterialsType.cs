using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningProject.Models
{
    public class MaterialsType
    {
        [Key]
        public int Id { get; set; }
        public string Tipi { get; set; }
        public ICollection<Materials> Materials { get; set; }
    }
}