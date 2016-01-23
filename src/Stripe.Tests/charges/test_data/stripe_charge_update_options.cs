using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_charge_update_options
    {
        public static StripeChargeUpdateOptions Valid()
        {
            return new StripeChargeUpdateOptions
            {
                Description = "Gangster Pancakes (syrup@og.com)",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                },
                ReceiptEmail = "syrup@og.com"
            };
        }
    }
}