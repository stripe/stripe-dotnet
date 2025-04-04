// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeListOptions : ListOptions
    {
        /// <summary>
        /// Only return Issuing disputes that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Select Issuing disputes with the given status.
        /// One of: <c>expired</c>, <c>lost</c>, <c>submitted</c>, <c>unsubmitted</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Select the Issuing dispute for the given transaction.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public string Transaction { get; set; }
    }
}
