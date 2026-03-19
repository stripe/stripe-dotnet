// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DebitReversalStatusTransitions : StripeEntity<DebitReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the DebitReversal changed status to <c>completed</c>.
        /// </summary>
        [JsonProperty("completed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("completed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CompletedAt { get; set; }
    }
}
