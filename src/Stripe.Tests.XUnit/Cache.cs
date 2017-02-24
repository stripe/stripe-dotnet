using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static string ApiKey => Environment.GetEnvironmentVariable("stripe_test_secret_key");
    }
}
