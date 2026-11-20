// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeStatusTransitions : StripeEntity<DisputeStatusTransitions>
    {
        /// <summary>
        /// The time at which the Dispute became lost. Only present if status == lost.
        /// </summary>
        [JsonProperty("lost_at")]
        [STJS.JsonPropertyName("lost_at")]
        public DateTime? LostAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time at which the Dispute became won. Only present if status == won.
        /// </summary>
        [JsonProperty("won_at")]
        [STJS.JsonPropertyName("won_at")]
        public DateTime? WonAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
