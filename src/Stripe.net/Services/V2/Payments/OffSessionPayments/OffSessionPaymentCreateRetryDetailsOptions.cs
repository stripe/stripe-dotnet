// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateRetryDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The pre-configured retry policy to use for the payment.
        /// </summary>
        [JsonProperty("retry_policy")]
        [STJS.JsonPropertyName("retry_policy")]
        public string RetryPolicy { get; set; }

        /// <summary>
        /// Indicates the strategy for how you want Stripe to retry the payment.
        /// One of: <c>best_available</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("retry_strategy")]
        [STJS.JsonPropertyName("retry_strategy")]
        public string RetryStrategy { get; set; }
    }
}
