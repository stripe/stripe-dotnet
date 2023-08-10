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

    public class SubscriptionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("automatic_tax")]
        public SubscriptionAutomaticTaxOptions AutomaticTax { get; set; }

        [JsonProperty("collection_method")]
        public string CollectionMethod { get; set; }

        [JsonProperty("current_period_end")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodEnd { get; set; }

        [JsonProperty("current_period_start")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> CurrentPeriodStart { get; set; }

        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("plan")]
        public string Plan { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("test_clock")]
        public string TestClock { get; set; }
    }
}
