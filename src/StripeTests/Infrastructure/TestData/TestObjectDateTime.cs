namespace StripeTests.Infrastructure.TestData
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TestObjectDateTime
    {
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Date { get; set; }
    }
}
