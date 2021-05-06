
using RightWay.ClassLib;

namespace Rightway.ClassLib
{
    public class Product
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsFeatured { get; set; }

        public DiscountedProduct ApplyDiscountFor(IUserContext user)
        {
            bool preferred = user.IsInRole(Role.PreferredCustomer);

            decimal discount = preferred ? .95m : 1.00m;

            return new DiscountedProduct(
                name: this.Name,
                unitPrice: this.UnitPrice * discount);
        }
    }
}