using System;

namespace RightWay.ClassLib
{
    public class DiscountedProduct
    {
        public DiscountedProduct(string name, decimal unitPrice)
        {
            this.Name = name ?? throw new ArgumentNullException("name");
            this.UnitPrice = unitPrice;
        }

        public string Name { get; }
        public decimal UnitPrice { get; }
    }
}