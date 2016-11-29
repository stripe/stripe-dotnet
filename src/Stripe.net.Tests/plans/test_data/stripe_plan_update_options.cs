using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_plan_update_options
    {
        public static StripePlanUpdateOptions Valid()
        {
            return new StripePlanUpdateOptions()
            {
                Name = "Test Plan Modified",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" },
                    { "C", "Value-C" }
                },
                StatementDescriptor = "heyyyy ya?"
            };
        }
    }
}
