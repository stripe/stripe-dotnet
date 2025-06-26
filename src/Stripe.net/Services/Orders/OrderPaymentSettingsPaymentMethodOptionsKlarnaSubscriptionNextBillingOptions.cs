// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderPaymentSettingsPaymentMethodOptionsKlarnaSubscriptionNextBillingOptions : INestedOptions
    {
        /// <summary>
        /// The amount of the next charge for the subscription.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The date of the next charge for the subscription in YYYY-MM-DD format.
        /// </summary>
        [JsonProperty("date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("date")]
#endif
        public string Date { get; set; }
    }
}
