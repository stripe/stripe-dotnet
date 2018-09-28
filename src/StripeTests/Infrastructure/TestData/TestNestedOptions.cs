namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;

    public class TestNestedOptions : INestedOptions
    {
        [FormProperty("an_int")]
        public int? AnInt { get; set; }

        [FormProperty("a_string")]
        public string AString { get; set; }
    }
}
