using NortwindExample.Entities;
using System.Collections.Generic;

namespace NortwindExample.MvcWebUI
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}