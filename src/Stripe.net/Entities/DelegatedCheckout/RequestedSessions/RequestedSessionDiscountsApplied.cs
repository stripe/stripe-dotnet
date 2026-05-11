// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionDiscountsApplied : StripeEntity<RequestedSessionDiscountsApplied>
    {
        /// <summary>
        /// The amount off provided by this discount.
        /// </summary>
        [JsonProperty("amount_off")]
        [STJS.JsonPropertyName("amount_off")]
        public long? AmountOff { get; set; }

        /// <summary>
        /// The discount code.
        /// </summary>
        [JsonProperty("code")]
        [STJS.JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The currency of the discount amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The unique key of the applied discount.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// The display name of the discount.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The percentage off provided by this discount.
        /// </summary>
        [JsonProperty("percent_off")]
        [STJS.JsonPropertyName("percent_off")]
        public decimal? PercentOff { get; set; }

        /// <summary>
        /// The type of discount.
        /// One of: <c>cart</c>, or <c>fulfillment</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
