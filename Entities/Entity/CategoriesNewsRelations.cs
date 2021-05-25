using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class CategoriesNewsRelations
    {
        public int Id { get; set; }
        public string CategoryCode { get; set; }
        public int NewsCode { get; set; }
    }
}
