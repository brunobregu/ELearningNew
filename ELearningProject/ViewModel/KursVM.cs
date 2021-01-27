using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningProject.ViewModel
{
    public class KursVM
    {
        [Display(Name ="Emri i kursit")]
        [Required(ErrorMessage ="Fusha duhet te plotesohet")]
        public string EmriKursit { get; set; }
        [Required(ErrorMessage = "Fusha duhet te plotesohet")]
        public string Pershkrimi { get; set; }
        [Required(ErrorMessage = "Ju lutem zgjidhni nje foto")]
        public HttpPostedFileWrapper Picture { get; set; }
    }
}