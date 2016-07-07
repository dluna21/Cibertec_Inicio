using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebDeveloper.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Passowrd")]
        public string Password { get; set; }
        [Display(Name = "Remenber Me?")]
        public bool RemenberMe { get; set; }
    }
}