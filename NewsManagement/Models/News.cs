using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsManagement.Models
{
    public class News
    {
        public string Image { get; set; }
        public string Id { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Summary { get; set; }

        [AllowHtml]
        public string Body { get; set; }
        public DateTime DateCreation { get; set; }
        public int CategoryId { get; set; }
    }
}