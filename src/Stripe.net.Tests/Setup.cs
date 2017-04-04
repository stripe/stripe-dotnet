using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class Setup : IAssemblyContext
    {
        void IAssemblyContext.OnAssemblyStart()
        {
            var envKey = Environment.GetEnvironmentVariable("STRIPE_TEST_KEY");

            StripeConfiguration.SetApiKey(envKey);
        }

        void IAssemblyContext.OnAssemblyComplete()
        {
            // great, we're done! nothing to cleanup.
        }
    }
}