using System;

namespace Stripe.Tests.xUnit
{
    public abstract class test
    {
        protected readonly string _stripe_api_key = Environment.GetEnvironmentVariable("stripe_test_secret_key");
    }
}
