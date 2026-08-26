// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApprovalRequestListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by action type (e.g. "refund.create", "payment_intent.create", "payout.create").
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Filter by creation time.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public ApprovalRequestListCreatedOptions Created { get; set; }

        /// <summary>
        /// Filter by approval request status (e.g. "requires_review", "approved", "succeeded",
        /// "failed", "rejected", "canceled", "expired").
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
