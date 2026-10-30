// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateTermRecurringPriceOptions : INestedOptions
    {
        /// <summary>
        /// The exclusive end. Omitted means open-ended.
        /// </summary>
        [JsonProperty("ends_at")]
        [STJS.JsonPropertyName("ends_at")]
        public ContractCreateTermRecurringPriceEndsAtOptions EndsAt { get; set; }

        /// <summary>
        /// The V1 recurring Price.
        /// </summary>
        [JsonProperty("price")]
        [STJS.JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// Initial licensed quantity. Defaults to 1; must be omitted for metered Prices.
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
        public ContractCreateTermRecurringPriceStartsAtOptions StartsAt { get; set; }
    }
}
