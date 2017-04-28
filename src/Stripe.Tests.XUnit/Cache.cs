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

        public static string ApiKey => Environment.GetEnvironmentVariable("STRIPE_TEST_KEY");
        public static string RecipientApiKey => Environment.GetEnvironmentVariable("STRIPE_RECIPIENT_KEY");

        /// <summary>
        /// This flag should be set to true if you are working from a new test account on stripe. By checking for this flag, we can speed up some list tests, etc.
        /// </summary>
        public static bool FirstRun => false;
    }
}
