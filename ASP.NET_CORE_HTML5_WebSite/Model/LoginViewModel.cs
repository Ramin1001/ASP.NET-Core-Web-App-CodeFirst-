using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Model
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Login")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
