using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rightway.ClassLib
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetFeaturedProducts();
    }
}
