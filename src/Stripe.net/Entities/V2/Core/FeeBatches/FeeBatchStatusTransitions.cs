// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeeBatchStatusTransitions : StripeEntity<FeeBatchStatusTransitions>
    {
        /// <summary>
        /// Timestamp of when the batch transitioned to BILLED, if applicable.
        /// </summary>
        [JsonProperty("billed_at")]
        [STJS.JsonPropertyName("billed_at")]
        public DateTime? BilledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Present only when <c>status=canceled</c>; <c>billed_at</c> and <c>canceled_at</c> are
        /// mutually exclusive.
        /// </summary>
        [JsonProperty("canceled_at")]
        [STJS.JsonPropertyName("canceled_at")]
        public DateTime? CanceledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;
    }
}
