using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Page name (title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Page content")]
        public override string Text { get; set; } = "Content is filled in by the administrator";
    }
}
