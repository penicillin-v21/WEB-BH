using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEBMUABANLAPTOP.Areas.Admin.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Please enter your username")]
        public String UserName { set; get; }
        [Required(ErrorMessage ="Please enter your password")]
        public String Password { set; get; }
    }
}