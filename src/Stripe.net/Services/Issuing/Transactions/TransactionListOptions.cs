// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionListOptions : ListOptions
    {
        /// <summary>
        /// Only return transactions that belong to the given card.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public string Card { get; set; }

        /// <summary>
        /// Only return transactions that belong to the given cardholder.
        /// </summary>
        [JsonProperty("cardholder")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder")]
#endif
        public string Cardholder { get; set; }

        /// <summary>
        /// Only return transactions that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return transactions that have the given type. One of <c>capture</c> or
        /// <c>refund</c>.
        /// One of: <c>capture</c>, or <c>refund</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
