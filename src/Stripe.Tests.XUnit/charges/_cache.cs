using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeCharge GetStripeCharge(string apiKey)
        {
            return new StripeChargeService(apiKey).Create(GetStripeChargeCreateOptions());
        }

        public static StripeChargeCreateOptions GetStripeChargeCreateOptions()
        {
            return new StripeChargeCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                SourceCard = new SourceCard
                {
                    Number = "4242424242424242",
                    ExpirationYear = 2022,
                    ExpirationMonth = 10,
                    Name = "John Doe"
                },
                Shipping = new StripeShippingOptions
                {
                    Name = "Namey Namerson",
                    Line1 = "123 Main St",
                    Line2 = "Apt B",
                    Country = "USA",
                    State = "NC"
                }
            };
        }
    }
}
