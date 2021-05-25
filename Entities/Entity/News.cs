using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class News
    {
        public int Code { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int View_Count { get; set; }
        public string Summary { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public string Headline_Image_Url { get; set; }
        public string Image_Url { get; set; }
        public byte Status { get; set; }
        public string MyProperty { get; set; }
    }
}
