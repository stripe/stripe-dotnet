// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsSurcharge : StripeEntity<PaymentIntentAmountDetailsSurcharge>
    {
        /// <summary>
        /// Portion of the amount that corresponds to a surcharge.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Indicate whether to enforce validations on the surcharge amount.
        /// One of: <c>automatic</c>, <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("enforce_validation")]
        [STJS.JsonPropertyName("enforce_validation")]
        public string EnforceValidation { get; set; }

        /// <summary>
        /// The maximum amount allowed for the surcharge.
        /// </summary>
        [JsonProperty("maximum_amount")]
        [STJS.JsonPropertyName("maximum_amount")]
        public long MaximumAmount { get; set; }

        /// <summary>
        /// The status of the surcharge.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
