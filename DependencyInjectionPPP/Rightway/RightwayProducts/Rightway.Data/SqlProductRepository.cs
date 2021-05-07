using Rightway.ClassLib;
using System;
using System.Collections.Generic;

namespace Rightway.Data
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly CommerceContext context;

        public SqlProductRepository(CommerceContext context)
        {
            this.context = context ?? throw new ArgumentNullException("context");
        }
        public IEnumerable<Product> GetFeaturedProducts()
        {
            return from product in context.Products
                   where product.IsFeatured
                   select product;
        }
    }
}
