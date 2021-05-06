using System;
using System.Collections.Generic;

namespace RightWay.ClassLib
{
    public interface IProductService
    {
        IEnumerable<DiscountedProduct> GetFeaturedProducts();
    }
}
