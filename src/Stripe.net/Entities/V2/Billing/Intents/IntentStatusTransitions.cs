// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class IntentStatusTransitions : StripeEntity<IntentStatusTransitions>
    {
        /// <summary>
        /// Time at which the Billing Intent was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled_at")]
#endif
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Time at which the Billing Intent was committed.
        /// </summary>
        [JsonProperty("committed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("committed_at")]
#endif
        public DateTime? CommittedAt { get; set; }

        /// <summary>
        /// Time at which the Billing Intent was drafted.
        /// </summary>
        [JsonProperty("drafted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("drafted_at")]
#endif
        public DateTime? DraftedAt { get; set; }

        /// <summary>
        /// Time at which the Billing Intent was reserved.
        /// </summary>
        [JsonProperty("reserved_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reserved_at")]
#endif
        public DateTime? ReservedAt { get; set; }
    }
}
