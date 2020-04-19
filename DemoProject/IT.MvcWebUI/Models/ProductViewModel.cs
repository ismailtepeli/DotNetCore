using IT.Entity.ComplexTypes;
using IT.Entity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public Product product { get; set; }

        public List<ProductCategoryComplexData> products { get; set; }

        public List<SelectListItem> Categories { get; set; } 
    }
}
