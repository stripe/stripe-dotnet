// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
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
        /// Time at which this transaction posted. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("posted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? PostedAt { get; set; }

        /// <summary>
        /// Time at which this transaction was voided. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("void_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("void_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? VoidAt { get; set; }
    }
}
