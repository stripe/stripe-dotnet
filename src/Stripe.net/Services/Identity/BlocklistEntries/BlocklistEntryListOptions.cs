// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BlocklistEntryListOptions : ListOptions
    {
        /// <summary>
        /// Only return BlocklistEntries that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return blocklist entries with the specified status.
        /// One of: <c>active</c>, <c>disabled</c>, or <c>redacted</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Only return blocklist entries of the specified type.
        /// One of: <c>document</c>, or <c>selfie</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Only return blocklist entries created from this verification report.
        /// </summary>
        [JsonProperty("verification_report")]
        [STJS.JsonPropertyName("verification_report")]
        public string VerificationReport { get; set; }
    }
}
