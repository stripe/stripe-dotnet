
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_order_create_options
    {
        public static StripeOrderCreateOptions Valid(string customerId, string skuId)
        {
            return new StripeOrderCreateOptions()
                       {
                           //Coupon = "coupon_id",
                           Currency = "aud",
                           CustomerId = customerId,
                           Email = "test@mail.com",
                           Metadata = new Dictionary<string, string>
                                        {
                                            { "ORD-A", "ORD-Value-A" },
                                            { "ORD-B", "ORD-Value-B" }
                                        },
                           Shipping = new StripeShippingOptions()
                                          {
                                              Address = new StripeAddress()
                                                            {
                                                                CityOrTown = "Sydney",
                                                                Country = "Australia",
                                                                Line1 = "355 George St.",
                                                                Line2 = "Level 2",
                                                                PostalCode = "2000",
                                                                State = "NSW"
                                                            },
                                                Name = "test customer",
                                                Phone = "0405299655"
                                          },
                            StripeOrderItems = new List<StripeOrderItem>()
                                                   {
                                                       new StripeOrderItem
                                                           {
                                                               Type = "sku",
                                                               Amount = 200,
                                                               Currency = "aud",
                                                               Description = "Order item 1",
                                                               ParentId = skuId,
                                                               Quantity = 2
                                                           }
                                                   }
                       };
        }
    }

        
}
