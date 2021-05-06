using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RightwayProducts.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using RightWay.ClassLib;

namespace RightwayProducts.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService ?? throw new ArgumentNullException("productService");
        }

        public ViewResult Index()
        {
            IEnumerable<DiscountedProduct> products = _productService.GetFeaturedProducts();

            var vm = new FeaturedProductsViewModel(
                from product in products
                select new ProductViewModel(product));

            return View(vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
