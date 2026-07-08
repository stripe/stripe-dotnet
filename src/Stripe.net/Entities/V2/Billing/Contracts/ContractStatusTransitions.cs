// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ContractStatusTransitions : StripeEntity<ContractStatusTransitions>
    {
        /// <summary>
        /// The timestamp when the contract was activated.
        /// </summary>
        [JsonProperty("activated_at")]
        [STJS.JsonPropertyName("activated_at")]
        public DateTime? ActivatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when the contract was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The timestamp when the contract ended.
        /// </summary>
        [JsonProperty("ended_at")]
        [STJS.JsonPropertyName("ended_at")]
        public DateTime? EndedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
