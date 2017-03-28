using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class order_fixture : IDisposable
    {

        public StripeOrder Order { get; }
        public StripeOrderCreateOptions OrderCreateOptions { get; }

        private StripeSku Sku { get; }
        private StripeProduct Product { get; }

        public order_fixture()
        {
            var skuFixture = new sku_fixture();
            Sku = skuFixture.SkuCreated;

            var productService = new StripeProductService(Cache.ApiKey);
            Product = productService.Get(Sku.ProductId);

            OrderCreateOptions = GetOrderCreateOptions();

            var orderService = new StripeOrderService(Cache.ApiKey);
            Order = orderService.Create(OrderCreateOptions);
        }

        public StripeOrderCreateOptions GetOrderCreateOptions()
        {
            var customer = Cache.GetCustomer();
            var options = new StripeOrderCreateOptions
            {
                Currency = "usd",
                CustomerId = customer.Id,
                Email = customer.Email,
                StripeOrderItems = new List<StripeOrderItem>
                {
                    new StripeOrderItem
                    {
                        Currency = "usd",
                        Description = Product.Description,
                        Type = "sku",
                        Amount = Convert.ToInt32(Sku.Price),
                        ParentId = Sku.Id,
                        Quantity = 1
                    }
                },
                Shipping = new StripeShippingOptions
                {
                    Name = Guid.NewGuid().ToString(),
                    Phone = "555-555-5555",
                    Address = new StripeAddress
                    {
                        Line1 = "5481 Creek Road",
                        Line2 = "Suite 1",
                        CityOrTown = "Cincinnati",
                        State = "OH",
                        PostalCode = "45242",
                        Country = "USA"
                    }
                },
                Metadata = new Dictionary<string, string>
                {
                    {"key", "value"}
                }
            };

            return options;
        }

        public void Dispose()
        {
        }
    }
}
