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

        public static StripeCharge GetStripeChargeUncaptured(string apiKey)
        {
            var options = GetStripeChargeCreateOptions();
            options.Capture = false;

            return new StripeChargeService(apiKey).Create(options);
        }

        public static StripeChargeCreateOptions GetStripeChargeCreateOptions()
        {
            return new StripeChargeCreateOptions
            {
                Amount = 1000,
                Currency = "usd",
                SourceTokenOrExistingSourceId = "tok_visa",
                Shipping = new StripeChargeShippingOptions
                {
                    Name = "Namey Namerson",
                    Line1 = "123 Main St",
                    Line2 = "Apt B",
                    Country = "USA",
                    State = "NC",
                    TrackingNumber = "12345",
                    Carrier = "Carrier",
                }
            };
        }
    }
}
