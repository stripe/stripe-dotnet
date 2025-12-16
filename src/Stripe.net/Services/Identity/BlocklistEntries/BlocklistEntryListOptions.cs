// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BlocklistEntryListOptions : ListOptions
    {
        /// <summary>
        /// Only return BlocklistEntries that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
#endif
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return blocklist entries with the specified status.
        /// One of: <c>active</c>, <c>disabled</c>, or <c>redacted</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// Only return blocklist entries of the specified type.
        /// One of: <c>document</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Only return blocklist entries created from this verification report.
        /// </summary>
        [JsonProperty("verification_report")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_report")]
#endif
        public string VerificationReport { get; set; }
    }
}
