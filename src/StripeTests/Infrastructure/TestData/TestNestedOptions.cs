namespace StripeTests.Infrastructure.TestData
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe;

    public class TestNestedOptions : INestedOptions
    {
        [JsonProperty("a_long")]
        public long? ALong { get; set; }

        [JsonProperty("a_string")]
        public string AString { get; set; }
    }
}
