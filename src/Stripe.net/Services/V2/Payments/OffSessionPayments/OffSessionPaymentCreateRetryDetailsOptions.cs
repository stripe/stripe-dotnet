// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentCreateRetryDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The pre-configured retry policy to use for the payment.
        /// </summary>
        [JsonProperty("retry_policy")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_policy")]
#endif
        public string RetryPolicy { get; set; }

        /// <summary>
        /// Indicates the strategy for how you want Stripe to retry the payment.
        /// One of: <c>best_available</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("retry_strategy")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("retry_strategy")]
#endif
        public string RetryStrategy { get; set; }
    }
}
