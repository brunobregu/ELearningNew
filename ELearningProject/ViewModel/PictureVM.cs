using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningProject.ViewModel
{
    public class PictureVM
    {
        [Required(ErrorMessage ="Ju lutem zgjidhni nje foto")]
        public HttpPostedFileWrapper Picture { get; set; }
    }
}