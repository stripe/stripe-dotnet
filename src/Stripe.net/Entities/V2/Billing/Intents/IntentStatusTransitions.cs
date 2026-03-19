// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IntentStatusTransitions : StripeEntity<IntentStatusTransitions>
    {
        /// <summary>
        /// Time at which the Billing Intent was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the Billing Intent was committed.
        /// </summary>
        [JsonProperty("committed_at")]
        [STJS.JsonPropertyName("committed_at")]
        public DateTime? CommittedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the Billing Intent was drafted.
        /// </summary>
        [JsonProperty("drafted_at")]
        [STJS.JsonPropertyName("drafted_at")]
        public DateTime? DraftedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which the Billing Intent was reserved.
        /// </summary>
        [JsonProperty("reserved_at")]
        [STJS.JsonPropertyName("reserved_at")]
        public DateTime? ReservedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
