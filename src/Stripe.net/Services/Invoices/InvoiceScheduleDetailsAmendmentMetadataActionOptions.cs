// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoiceScheduleDetailsAmendmentMetadataActionOptions : INestedOptions
    {
        /// <summary>
        /// Key-value pairs to add to schedule phase metadata. These values will merge with existing
        /// schedule phase metadata.
        /// </summary>
        [JsonProperty("add")]
        public Dictionary<string, string> Add { get; set; }

        /// <summary>
        /// Keys to remove from schedule phase metadata.
        /// </summary>
        [JsonProperty("remove")]
        public List<string> Remove { get; set; }

        /// <summary>
        /// Key-value pairs to set as schedule phase metadata. Existing schedule phase metadata will
        /// be overwritten.
        /// </summary>
        [JsonProperty("set")]
        public Dictionary<string, string> Set { get; set; }

        /// <summary>
        /// Select one of three ways to update phase-level <c>metadata</c> on subscription
        /// schedules.
        /// One of: <c>add</c>, <c>remove</c>, or <c>set</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
