// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditReversalStatusTransitions : StripeEntity<CreditReversalStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the CreditReversal changed status to <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
#endif

        public DateTime? PostedAt { get; set; }
    }
}
