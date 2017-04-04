using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class Setup : IAssemblyContext
    {
        void IAssemblyContext.OnAssemblyStart()
        {
            // using this temporarily while the main test account is deleting test data
            var envKey = Environment.GetEnvironmentVariable("STRIPE_RECIPIENT_KEY");

            //var envKey = Environment.GetEnvironmentVariable("STRIPE_TEST_KEY");

            StripeConfiguration.SetApiKey(envKey);
        }

        void IAssemblyContext.OnAssemblyComplete()
        {
            // great, we're done! nothing to cleanup.
        }
    }
}