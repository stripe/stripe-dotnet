// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkRestrictionsCompletedSessions : StripeEntity<PaymentLinkRestrictionsCompletedSessions>
    {
        /// <summary>
        /// The current number of checkout sessions that have been completed on the payment link
        /// which count towards the <c>completed_sessions</c> restriction to be met.
        /// </summary>
        [JsonProperty("count")]
        public long Count { get; set; }

        /// <summary>
        /// The maximum number of checkout sessions that can be completed for the
        /// <c>completed_sessions</c> restriction to be met.
        /// </summary>
        [JsonProperty("limit")]
        public long Limit { get; set; }
    }
}
