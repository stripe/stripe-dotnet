// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentRetryDetails : StripeEntity<OffSessionPaymentRetryDetails>
    {
        /// <summary>
        /// Number of authorization attempts so far.
        /// </summary>
        [JsonProperty("attempts")]
        [STJS.JsonPropertyName("attempts")]
        public long Attempts { get; set; }

        /// <summary>
        /// The pre-configured retry policy to use for the payment.
        /// </summary>
        [JsonProperty("retry_policy")]
        [STJS.JsonPropertyName("retry_policy")]
        public string RetryPolicy { get; set; }

        /// <summary>
        /// Indicates the strategy for how you want Stripe to retry the payment.
        /// One of: <c>heuristic</c>, <c>none</c>, <c>scheduled</c>, or <c>smart</c>.
        /// </summary>
        [JsonProperty("retry_strategy")]
        [STJS.JsonPropertyName("retry_strategy")]
        public string RetryStrategy { get; set; }
    }
}
