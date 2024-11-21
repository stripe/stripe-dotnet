// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DebitReversalStatusTransitions : StripeEntity<DebitReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the DebitReversal changed status to <c>completed</c>.
        /// </summary>
        [JsonProperty("completed_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("completed_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? CompletedAt { get; set; }
    }
}
