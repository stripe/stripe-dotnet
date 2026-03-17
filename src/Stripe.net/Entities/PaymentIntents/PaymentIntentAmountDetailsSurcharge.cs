// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsSurcharge : StripeEntity<PaymentIntentAmountDetailsSurcharge>
    {
        /// <summary>
        /// Portion of the amount that corresponds to a surcharge.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Indicate whether to enforce validations on the surcharge amount.
        /// One of: <c>automatic</c>, <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("enforce_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enforce_validation")]
#endif
        public string EnforceValidation { get; set; }

        /// <summary>
        /// The maximum amount allowed for the surcharge.
        /// </summary>
        [JsonProperty("maximum_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("maximum_amount")]
#endif
        public long MaximumAmount { get; set; }

        /// <summary>
        /// The status of the surcharge.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
