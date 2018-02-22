using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_topup_update_options
    {
        public static StripeTopupUpdateOptions Valid()
        {
            return new StripeTopupUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                }
            };
        }
    }
}
