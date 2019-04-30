namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class BalanceTransactionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A filter on the list based on the object available_on field. The value can be a
        /// <see cref="DateTime"/> or a <see cref="DateRangeOptions"/>.
        /// </summary>
        [JsonProperty("available_on")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> AvailableOn { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("payout")]
        public string PayoutId { get; set; }

        [JsonProperty("source")]
        public string SourceId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
