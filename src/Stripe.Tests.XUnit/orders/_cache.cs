using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeOrder GetOrder()
        {
            if (Items.ContainsKey("order")) return (StripeOrder)Items["order"];

            var order = new StripeOrderService(ApiKey).Create(GetOrderCreateOptions());
            Items.Add("order", order);

            return order;
        }

        public static StripeOrderCreateOptions GetOrderCreateOptions()
        {
            if (Items.ContainsKey("order_create_options")) return (StripeOrderCreateOptions)Items["order_create_options"];

            var customer = GetCustomer();
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
                        Description = GetProduct().Description,
                        Type = "sku",
                        Amount = Convert.ToInt32(GetSku().Price),
                        ParentId = GetSku().Id,
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

            Items.Add("order_create_options", options);

            return options;
        }
    }
}
