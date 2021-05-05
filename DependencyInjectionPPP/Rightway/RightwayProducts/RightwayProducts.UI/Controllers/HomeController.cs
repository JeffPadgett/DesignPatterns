using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RightwayProducts.UI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RightwayProducts.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            var vm = new FeaturedProductsViewModel( new[]
            {
                new ProductViewModel("Chocolate", 34.95m),
                new ProductViewModel("Asparagus", 39.80m)
            });

            return this.View(vm);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
