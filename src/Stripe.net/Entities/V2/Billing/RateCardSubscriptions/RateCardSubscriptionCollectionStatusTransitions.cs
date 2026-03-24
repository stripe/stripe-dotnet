// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RateCardSubscriptionCollectionStatusTransitions : StripeEntity<RateCardSubscriptionCollectionStatusTransitions>
    {
        /// <summary>
        /// When the collection status transitioned to awaiting customer action.
        /// </summary>
        [JsonProperty("awaiting_customer_action_at")]
        [STJS.JsonPropertyName("awaiting_customer_action_at")]
        public string AwaitingCustomerActionAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to current.
        /// </summary>
        [JsonProperty("current_at")]
        [STJS.JsonPropertyName("current_at")]
        public string CurrentAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to past due.
        /// </summary>
        [JsonProperty("past_due_at")]
        [STJS.JsonPropertyName("past_due_at")]
        public string PastDueAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to paused.
        /// </summary>
        [JsonProperty("paused_at")]
        [STJS.JsonPropertyName("paused_at")]
        public string PausedAt { get; set; }

        /// <summary>
        /// When the collection status transitioned to unpaid.
        /// </summary>
        [JsonProperty("unpaid_at")]
        [STJS.JsonPropertyName("unpaid_at")]
        public string UnpaidAt { get; set; }
    }
}
