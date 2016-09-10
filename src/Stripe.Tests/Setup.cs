using System;
using Machine.Specifications;

namespace Stripe.Tests
{
    public class Setup : IAssemblyContext
    {
        void IAssemblyContext.OnAssemblyStart()
        {
            var apiKey = "your_test_key_here";

            var envKey = Environment.GetEnvironmentVariable("test_api_key");
            if (!string.IsNullOrEmpty(envKey)) apiKey = envKey;

            StripeConfiguration.SetApiKey(apiKey);
        }

        void IAssemblyContext.OnAssemblyComplete()
        {
            // great, we're done!
        }
    }
}