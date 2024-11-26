// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionStatusTransitions : StripeEntity<TransactionStatusTransitions>
    {
        /// <summary>
        /// Timestamp describing when the Transaction changed status to <c>posted</c>.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Timestamp describing when the Transaction changed status to <c>void</c>.
        /// </summary>
        [JsonProperty("void_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("void_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? VoidAt { get; set; }
    }
}
