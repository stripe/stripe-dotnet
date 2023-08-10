// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;

/* Unmerged change from project 'Stripe.net(netcoreapp3.1)'
Before:
    using Stripe.Infrastructure;
    using Newtonsoft.Json.Converters;
After:
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;
*/
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;

    public class SubscriptionScheduleListOptions : ListOptionsWithCreated
    {
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CanceledAt { get; set; }

        [JsonProperty("completed_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CompletedAt { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("released_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ReleasedAt { get; set; }

        [JsonProperty("scheduled")]
        public bool? Scheduled { get; set; }
    }
}
