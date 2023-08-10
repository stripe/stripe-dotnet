// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;

    public class BalanceTransactionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("available_on")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> AvailableOn { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payout")]
        public string Payout { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
