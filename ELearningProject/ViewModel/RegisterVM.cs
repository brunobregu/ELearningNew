using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ELearningProject.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Fusha {0} duhet te plotesohet"), MinLength(2, ErrorMessage = "Fusha {0} duhet te kete me shume se 2 karaktere")]
        public string Emri { get; set; }
        [Required(ErrorMessage = "Fusha {0} duhet te plotesohet"), MinLength(3, ErrorMessage = "Fusha {0} duhet te kete me shume se 3 karaktere")]
        public string Mbiemri { get; set; }
        [Required(ErrorMessage = "Fusha {0} duhet te plotesohet"), MinLength(5, ErrorMessage = "Fusha {0} duhet te kete me shume se 5 karaktere")]
        public string Username { get; set; }
        [MinLength(5, ErrorMessage = "Fusha {0} duhet te kete me shume se 5 karaktere"), Required(ErrorMessage = "Fusha {0} duhet te plotesohet"), DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwordet nuk jane te njejte"), DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
        [EmailAddress(ErrorMessage = "Fusha {0} duhet te jete nje adrese e vlefshme emaili"), Required(ErrorMessage = "Fusha {0} duhet te plotesohet")]
        public string Email { get; set; }
    }
}