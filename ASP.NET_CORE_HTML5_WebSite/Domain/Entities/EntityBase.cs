using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_CORE_HTML5_WebSite.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }
        
        [Display(Name ="Title (head)")]
        public virtual string Title { get; set; }
        
        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "Title picture")]
        public virtual string TitleImagePath { get; set; }

        [Display(Name = "SEO Meta Tag Title")]
        public string MetaTitle { get; set; }

        [Display(Name = "SEO Meta Tag description")]
        public string MetaDescription { get; set; }

        [Display(Name = "SEO Meta Tag keywords")]
        public string MetaKeywords { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
