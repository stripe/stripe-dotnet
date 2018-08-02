namespace StripeTests.Infrastructure.TestData
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TestObjectDateTime
    {
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Date { get; set; }
    }
}