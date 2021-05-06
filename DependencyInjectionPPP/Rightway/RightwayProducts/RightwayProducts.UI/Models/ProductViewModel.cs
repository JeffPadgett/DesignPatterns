using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using RightWay.ClassLib;

namespace RightwayProducts.UI.Models
{
    public class ProductViewModel
    {
        //private static CultureInfo PriceCulture = new CultureInfo("en-US");
        public string SummaryText { get; }

        public ProductViewModel(DiscountedProduct discountedProduct)
        {
            this.SummaryText = $"{discountedProduct.Name} ({discountedProduct.UnitPrice:C}))";
        }
    }
}
