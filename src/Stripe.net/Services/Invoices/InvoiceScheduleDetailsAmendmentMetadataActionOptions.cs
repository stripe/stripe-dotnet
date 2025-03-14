// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsAmendmentMetadataActionOptions : INestedOptions
    {
        /// <summary>
        /// Key-value pairs to add to schedule phase metadata. These values will merge with existing
        /// schedule phase metadata.
        /// </summary>
        [JsonProperty("add")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("add")]
#endif
        public Dictionary<string, string> Add { get; set; }

        /// <summary>
        /// Keys to remove from schedule phase metadata.
        /// </summary>
        [JsonProperty("remove")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("remove")]
#endif
        public List<string> Remove { get; set; }

        /// <summary>
        /// Key-value pairs to set as schedule phase metadata. Existing schedule phase metadata will
        /// be overwritten.
        /// </summary>
        [JsonProperty("set")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("set")]
#endif
        public Dictionary<string, string> Set { get; set; }

        /// <summary>
        /// Select one of three ways to update phase-level <c>metadata</c> on subscription
        /// schedules.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
