using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter the name of the service")]
        [Display(Name = "Name of service")]
        public override string Title { get; set; } 

        [Display(Name = "Brief description of the service")]
        public override string Subtitle { get; set; }

        [Display(Name = "Brief description of the content")]
        public override string Text { get; set; } 
    }
}
