using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Banners
    {
        public int Code { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string image_Url { get; set; }
        public bool Status { get; set; }
    }
}
