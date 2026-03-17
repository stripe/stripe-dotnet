// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsSurchargeOptions : INestedOptions
    {
        /// <summary>
        /// Portion of the amount that corresponds to a surcharge.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Indicate whether to enforce validations on the surcharge amount.
        /// One of: <c>automatic</c>, <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("enforce_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enforce_validation")]
#endif
        public string EnforceValidation { get; set; }
    }
}
