// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractUpdateActionUpdateTermRecurringPriceOptions : INestedOptions
    {
        /// <summary>
        /// Omission leaves the end unchanged; never requests an open end.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractUpdateActionUpdateTermRecurringPriceEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// Update an active term's licensed quantity at the contract's current clock time, or an
        /// unstarted term's initial quantity, preserving its ID. Ended terms cannot change
        /// quantity.
        /// </summary>
        [JsonProperty("quantity")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Reschedule an unstarted term in place.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractUpdateActionUpdateTermRecurringPriceStartsAtOptions StartsAt { get; set; }
    }
}
