using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RightwayProducts.UI.Models
{
    public class FeaturedProductsViewModel
    {
        public IEnumerable<ProductViewModel> Products { get; }

        public FeaturedProductsViewModel(IEnumerable<ProductViewModel> products)
        {
            this.Products = products;
        }
    }
}
