// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionStatusTransitionsOptions : INestedOptions
    {
        /// <summary>
        /// Returns Transactions with <c>posted_at</c> within the specified range.
        /// </summary>
        [JsonProperty("posted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("posted_at")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif

        public AnyOf<DateTime?, DateRangeOptions> PostedAt { get; set; }
    }
}
