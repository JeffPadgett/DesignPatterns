using RightWay.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rightway.ClassLib
{
    class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly IUserContext userContext;

        public ProductService(IProductRepository repository, IUserContext userContext)
        {
            this.repository = repository ?? throw new ArgumentNullException("repository");
            this.userContext = userContext ?? throw new ArgumentNullException("userContext");
        }

        public IEnumerable<DiscountedProduct> GetFeaturedProducts()
        {
            return from product in repository.GetFeaturedProducts()
                   select product.ApplyDiscountFor(userContext);
        }
    }
}
