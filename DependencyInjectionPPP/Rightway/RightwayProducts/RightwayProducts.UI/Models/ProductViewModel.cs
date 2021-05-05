using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace RightwayProducts.UI.Models
{
    public class ProductViewModel
    {
        private static CultureInfo PriceCulture = new CultureInfo("en-US");
        public string SummaryText { get; }

        public ProductViewModel(string name, decimal unitPrice)
        {
            this.SummaryText = $"{name} ({unitPrice:C}))";
        }
    }
}
