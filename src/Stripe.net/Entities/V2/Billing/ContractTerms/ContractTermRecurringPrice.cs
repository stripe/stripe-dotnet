// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractTermRecurringPrice : StripeEntity<ContractTermRecurringPrice>
    {
        /// <summary>
        /// The exclusive end of the term. Null for an open end.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractTermRecurringPriceEndsAt EndsAt { get; set; }

        /// <summary>
        /// The V1 recurring Price.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Current licensed quantity. Null for metered Prices; history is available separately.
        /// </summary>
        [JsonProperty("quantity")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("quantity")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The inclusive start of the term.
        /// </summary>
        [JsonProperty("starts_at")]
        [STJS.JsonPropertyName("starts_at")]
        public ContractTermRecurringPriceStartsAt StartsAt { get; set; }
    }
}
