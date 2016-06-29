using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QAProj.Models
{
    public class BlogPost
    {
        public string Title { get; set; }
        [System.ComponentModel.DataAnnotations.UIHint("tinymce_jquery_full"), AllowHtml]
        public string Body { get; set; }
        public string Tags { get; set; }
        public DateTime PostDate { get; set; }
    }
    
}