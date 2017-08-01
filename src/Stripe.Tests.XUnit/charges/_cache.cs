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
                SourceTokenOrExistingSourceId = "tok_visa",
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
