using IT.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public Product product { get; set; }

        public List<Product> products { get; set; }
    }
}
