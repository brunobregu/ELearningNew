using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ELearningProject.Models
{
    public class Materials
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string EmriTemes { get; set; }
        public string MaterialsPath { get; set; }
        public DateTime PostedOn { get; set; }
        public string PostedBy { get; set; }
        public int KursId { get; set; }
        [ForeignKey("KursId")]
        public virtual Kursi Kursi { get; set; }
        public int TipId { get; set; }
        [ForeignKey("TipId")]
        public virtual MaterialsType MaterialsType { get; set; }
    }
}