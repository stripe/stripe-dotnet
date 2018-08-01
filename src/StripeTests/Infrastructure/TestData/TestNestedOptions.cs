namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;

    public class TestNestedOptions : INestedOptions
    {
        [JsonProperty("an_int")]
        public int? AnInt { get; set; }

        [JsonProperty("a_string")]
        public string AString { get; set; }
    }
}