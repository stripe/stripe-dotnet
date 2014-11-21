using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_customer_update_options
    {
        public static StripeCustomerUpdateOptions Valid()
        {
            var stripeCustomerUpdateOptions = new StripeCustomerUpdateOptions()
            {
                Description = "Gangster Pancakes (syrup@og.com)",
                AccountBalance = 1000,
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                }
            };

            return stripeCustomerUpdateOptions;
        }
    }
}
