// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkRestrictionsCompletedSessions : StripeEntity<PaymentLinkRestrictionsCompletedSessions>
    {
        /// <summary>
        /// The current number of checkout sessions that have been completed on the payment link
        /// which count towards the <c>completed_sessions</c> restriction to be met.
        /// </summary>
        [JsonProperty("count")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("count")]
#endif

        public long Count { get; set; }

        /// <summary>
        /// The maximum number of checkout sessions that can be completed for the
        /// <c>completed_sessions</c> restriction to be met.
        /// </summary>
        [JsonProperty("limit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("limit")]
#endif

        public long Limit { get; set; }
    }
}
