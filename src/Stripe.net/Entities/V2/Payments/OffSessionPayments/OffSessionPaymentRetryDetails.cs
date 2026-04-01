// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System;
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

        /// <summary>
        /// The timestamp when this payment is no longer eligible to be retried. When this timestamp
        /// is reached, the payment will be marked as failed.
        /// </summary>
        [JsonProperty("retry_until")]
        [STJS.JsonPropertyName("retry_until")]
        public DateTime? RetryUntil { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
