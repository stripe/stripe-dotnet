using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static string ApiKey => Environment.GetEnvironmentVariable("stripe_test_secret_key");

        public static Dictionary<string, object> Items => new Dictionary<string, object>();
    }
}
