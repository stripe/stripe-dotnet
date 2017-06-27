using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    /// <summary>
    /// A cache utility that provides objects and options for testing
    /// </summary>
    public static partial class Cache
    {
        static Cache()
        {
            Items = new Dictionary<string, object>();
        }

        /// <summary>
        /// This holds a list of cached items for re-use. Customers, Plans, Subscriptions, etc.
        /// </summary>
        public static Dictionary<string, object> Items { get; set; }

        public static string ApiKey => Environment.GetEnvironmentVariable("STRIPE_TEST_SK");
    }
}
