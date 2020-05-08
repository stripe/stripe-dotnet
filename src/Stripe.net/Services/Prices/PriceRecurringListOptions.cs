namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PriceRecurringListOptions : INestedOptions
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }

        [JsonProperty("usage_type")]
        public string UsageType { get; set; }
    }
}
