using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningProject.ViewModel
{
    public class ChangePasswordVM
    {
        [Display(Name = "Passwordi i vjeter")]
        [Required(ErrorMessage = "Fusha eshte e kerkuar")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }
        [Display(Name = "Passwordi i ri")]
        [Required(ErrorMessage = "Fusha eshte e kerkuar")]
        [MinLength(5, ErrorMessage ="Fusha {0} duhet te kete me shume se 5 karaktere")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Fusha eshte e kerkuar")]
        [DataType(DataType.Password)]
        [Compare(otherProperty: "NewPassword", ErrorMessage = "Fushat nuk jane te njejta")]
        public string ConfirmPassword { get; set; }
    }
}