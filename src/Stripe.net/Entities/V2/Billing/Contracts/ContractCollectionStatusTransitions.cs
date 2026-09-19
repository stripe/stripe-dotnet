// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractCollectionStatusTransitions : StripeEntity<ContractCollectionStatusTransitions>
    {
        /// <summary>
        /// The timestamp when the contract's collection status transitioned to blocked.
        /// </summary>
        [JsonProperty("blocked_at")]
        [STJS.JsonPropertyName("blocked_at")]
        public DateTime? BlockedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when the contract's collection status transitioned to current.
        /// </summary>
        [JsonProperty("current_at")]
        [STJS.JsonPropertyName("current_at")]
        public DateTime? CurrentAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when the contract's collection status transitioned to past due.
        /// </summary>
        [JsonProperty("past_due_at")]
        [STJS.JsonPropertyName("past_due_at")]
        public DateTime? PastDueAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when the contract's collection status transitioned to unpaid.
        /// </summary>
        [JsonProperty("unpaid_at")]
        [STJS.JsonPropertyName("unpaid_at")]
        public DateTime? UnpaidAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
